using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace CalendarManagemenrSystem
{
    public partial class addEventForm : Form
    {

        string date;

        public addEventForm()
        {
            Width = 100;
            Height = 450;

            InitializeComponent();
        }

        public addEventForm(string d)
        {
            InitializeComponent();
            dateLabel.Text += d;
            date = d;

            initializeTimeSections();
        }

        private void initializeTimeSections()
        {
            #region startTime
            comboBox1.Items.Add("00:00");
            comboBox1.Items.Add("00:30");
            comboBox1.Items.Add("01:00");
            comboBox1.Items.Add("01:30");
            comboBox1.Items.Add("02:00");
            comboBox1.Items.Add("02:30");
            comboBox1.Items.Add("03:00");
            comboBox1.Items.Add("03:30");
            comboBox1.Items.Add("04:00");
            comboBox1.Items.Add("04:30");
            comboBox1.Items.Add("05:00");
            comboBox1.Items.Add("05:30");
            comboBox1.Items.Add("06:00");
            comboBox1.Items.Add("06:30");
            comboBox1.Items.Add("07:00");
            comboBox1.Items.Add("07:30");
            comboBox1.Items.Add("08:00");
            comboBox1.Items.Add("08:30");
            comboBox1.Items.Add("09:00");
            comboBox1.Items.Add("09:30");
            comboBox1.Items.Add("10:00");
            comboBox1.Items.Add("10:30");
            comboBox1.Items.Add("11:00");
            comboBox1.Items.Add("11:30");

            comboBox1.Items.Add("12:00");
            comboBox1.Items.Add("12:30");
            comboBox1.Items.Add("13:00");
            comboBox1.Items.Add("13:30");
            comboBox1.Items.Add("14:00");
            comboBox1.Items.Add("14:30");
            comboBox1.Items.Add("15:00");
            comboBox1.Items.Add("15:30");
            comboBox1.Items.Add("16:00");
            comboBox1.Items.Add("16:30");
            comboBox1.Items.Add("17:00");
            comboBox1.Items.Add("17:30");
            comboBox1.Items.Add("18:00");
            comboBox1.Items.Add("18:30");
            comboBox1.Items.Add("19:00");
            comboBox1.Items.Add("19:30");
            comboBox1.Items.Add("20:00");
            comboBox1.Items.Add("20:30");
            comboBox1.Items.Add("21:00");
            comboBox1.Items.Add("21:30");
            comboBox1.Items.Add("22:00");
            comboBox1.Items.Add("22:30");
            comboBox1.Items.Add("23:00");
            comboBox1.Items.Add("23:30");
            comboBox1.Items.Add("24:00");

            #endregion
            #region endTime
            comboBox2.Items.Add("00:00");
            comboBox2.Items.Add("00:30");
            comboBox2.Items.Add("01:00");
            comboBox2.Items.Add("01:30");
            comboBox2.Items.Add("02:00");
            comboBox2.Items.Add("02:30");
            comboBox2.Items.Add("03:00");
            comboBox2.Items.Add("03:30");
            comboBox2.Items.Add("04:00");
            comboBox2.Items.Add("04:30");
            comboBox2.Items.Add("05:00");
            comboBox2.Items.Add("05:30");
            comboBox2.Items.Add("06:00");
            comboBox2.Items.Add("06:30");
            comboBox2.Items.Add("07:00");
            comboBox2.Items.Add("07:30");
            comboBox2.Items.Add("08:00");
            comboBox2.Items.Add("08:30");
            comboBox2.Items.Add("09:00");
            comboBox2.Items.Add("09:30");
            comboBox2.Items.Add("10:00");
            comboBox2.Items.Add("10:30");
            comboBox2.Items.Add("11:00");
            comboBox2.Items.Add("11:30");

            comboBox2.Items.Add("12:00");
            comboBox2.Items.Add("12:30");
            comboBox2.Items.Add("13:00");
            comboBox2.Items.Add("13:30");
            comboBox2.Items.Add("14:00");
            comboBox2.Items.Add("14:30");
            comboBox2.Items.Add("15:00");
            comboBox2.Items.Add("15:30");
            comboBox2.Items.Add("16:00");
            comboBox2.Items.Add("16:30");
            comboBox2.Items.Add("17:00");
            comboBox2.Items.Add("17:30");
            comboBox2.Items.Add("18:00");
            comboBox2.Items.Add("18:30");
            comboBox2.Items.Add("19:00");
            comboBox2.Items.Add("19:30");
            comboBox2.Items.Add("20:00");
            comboBox2.Items.Add("20:30");
            comboBox2.Items.Add("21:00");
            comboBox2.Items.Add("21:30");
            comboBox2.Items.Add("22:00");
            comboBox2.Items.Add("22:30");
            comboBox2.Items.Add("23:00");
            comboBox2.Items.Add("23:30");
            comboBox2.Items.Add("24:00");

            #endregion

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add new event to database
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                
                string sql = "INSERT INTO victorgomezevent (Title, StartTime, EndTime, Date, Description, employeeID) " +
                    "VALUES (@title, @Start, @End, @myDate, @desc, @id)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@myDate", date);
                cmd.Parameters.AddWithValue("@id", MainForm.ID);
                cmd.Parameters.AddWithValue("@title", textBox1.Text);
                cmd.Parameters.AddWithValue("@Start", comboBox1.Text + ":00");
                cmd.Parameters.AddWithValue("@End", comboBox2.Text + ":00");
                cmd.Parameters.AddWithValue("@desc", textBox4.Text);

                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Event Added");
                }
                else
                {
                    Console.Out.WriteLine("Event could not be added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            MainForm.fillList(date);
            Close();
        }

        private void addEventForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
