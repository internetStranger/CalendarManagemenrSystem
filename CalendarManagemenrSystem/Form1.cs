using Google.Protobuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarManagemenrSystem
{

    public partial class MainForm : Form
    {
        static ArrayList eList;

        public static int ID;

        loginForm login = new loginForm();
        Monthly_Events_Form monthlyEvents = new Monthly_Events_Form();

        public static MonthCalendar cal;

        public string thisDate;

        static TextBox instance1;
        static ComboBox instance2;
        static ComboBox instance3;
        static TextBox instance4;

        static ListBox listInstance;
        static ArrayList eventsInstance;

        public MainForm()
        {
            InitializeComponent();
            initializeTimeSections();
        }

        public MainForm(int id)
        {
            InitializeComponent();
            initializeTimeSections();
            ID = id;

            instance1 = textBox1;
            instance2 = startTimeBox;
            instance3 = endTimeBox;
            instance4 = textBox4;

            listInstance = EventsList;
            eventsInstance = eList;

            cal = monthCalendar1;

            DateTime thisDay = DateTime.Today;
            String dateString = thisDay.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

            eList = Event.getEventList(dateString, ID);

            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                String aString = currentEvent.getStartTime() + "  " + currentEvent.getTitle();
                EventsList.Items.Add(aString);
            }

        }

        public static void fillList(string d)
        {
            listInstance.Items.Clear();

            eventsInstance = Event.getEventList(d, ID);
            for(int i = 0; i < eventsInstance.Count; i++)
            {
                Event currentEvent = (Event)eventsInstance[i];
                string aString = currentEvent.getStartTime() + "  " + currentEvent.getTitle();
                listInstance.Items.Add(aString);
            }

            eList = eventsInstance;
        }

        private void initializeTimeSections()
        {
            #region startTime
            startTimeBox.Items.Add("00:00");
            startTimeBox.Items.Add("00:30");
            startTimeBox.Items.Add("01:00");
            startTimeBox.Items.Add("01:30");
            startTimeBox.Items.Add("02:00");
            startTimeBox.Items.Add("02:30");
            startTimeBox.Items.Add("03:00");
            startTimeBox.Items.Add("03:30");
            startTimeBox.Items.Add("04:00");
            startTimeBox.Items.Add("04:30");
            startTimeBox.Items.Add("05:00");
            startTimeBox.Items.Add("05:30");
            startTimeBox.Items.Add("06:00");
            startTimeBox.Items.Add("06:30");
            startTimeBox.Items.Add("07:00");
            startTimeBox.Items.Add("07:30");
            startTimeBox.Items.Add("08:00");
            startTimeBox.Items.Add("08:30");
            startTimeBox.Items.Add("09:00");
            startTimeBox.Items.Add("09:30");
            startTimeBox.Items.Add("10:00");
            startTimeBox.Items.Add("10:30");
            startTimeBox.Items.Add("11:00");
            startTimeBox.Items.Add("11:30");

            startTimeBox.Items.Add("12:00");
            startTimeBox.Items.Add("12:30");
            startTimeBox.Items.Add("13:00");
            startTimeBox.Items.Add("13:30");
            startTimeBox.Items.Add("14:00");
            startTimeBox.Items.Add("14:30");
            startTimeBox.Items.Add("15:00");
            startTimeBox.Items.Add("15:30");
            startTimeBox.Items.Add("16:00");
            startTimeBox.Items.Add("16:30");
            startTimeBox.Items.Add("17:00");
            startTimeBox.Items.Add("17:30");
            startTimeBox.Items.Add("18:00");
            startTimeBox.Items.Add("18:30");
            startTimeBox.Items.Add("19:00");
            startTimeBox.Items.Add("19:30");
            startTimeBox.Items.Add("20:00");
            startTimeBox.Items.Add("20:30");
            startTimeBox.Items.Add("21:00");
            startTimeBox.Items.Add("21:30");
            startTimeBox.Items.Add("22:00");
            startTimeBox.Items.Add("22:30");
            startTimeBox.Items.Add("23:00");
            startTimeBox.Items.Add("23:30");
            startTimeBox.Items.Add("24:00");

            #endregion
            #region endTime
            endTimeBox.Items.Add("00:00");
            endTimeBox.Items.Add("00:30");
            endTimeBox.Items.Add("01:00");
            endTimeBox.Items.Add("01:30");
            endTimeBox.Items.Add("02:00");
            endTimeBox.Items.Add("02:30");
            endTimeBox.Items.Add("03:00");
            endTimeBox.Items.Add("03:30");
            endTimeBox.Items.Add("04:00");
            endTimeBox.Items.Add("04:30");
            endTimeBox.Items.Add("05:00");
            endTimeBox.Items.Add("05:30");
            endTimeBox.Items.Add("06:00");
            endTimeBox.Items.Add("06:30");
            endTimeBox.Items.Add("07:00");
            endTimeBox.Items.Add("07:30");
            endTimeBox.Items.Add("08:00");
            endTimeBox.Items.Add("08:30");
            endTimeBox.Items.Add("09:00");
            endTimeBox.Items.Add("09:30");
            endTimeBox.Items.Add("10:00");
            endTimeBox.Items.Add("10:30");
            endTimeBox.Items.Add("11:00");
            endTimeBox.Items.Add("11:30");

            endTimeBox.Items.Add("12:00");
            endTimeBox.Items.Add("12:30");
            endTimeBox.Items.Add("13:00");
            endTimeBox.Items.Add("13:30");
            endTimeBox.Items.Add("14:00");
            endTimeBox.Items.Add("14:30");
            endTimeBox.Items.Add("15:00");
            endTimeBox.Items.Add("15:30");
            endTimeBox.Items.Add("16:00");
            endTimeBox.Items.Add("16:30");
            endTimeBox.Items.Add("17:00");
            endTimeBox.Items.Add("17:30");
            endTimeBox.Items.Add("18:00");
            endTimeBox.Items.Add("18:30");
            endTimeBox.Items.Add("19:00");
            endTimeBox.Items.Add("19:30");
            endTimeBox.Items.Add("20:00");
            endTimeBox.Items.Add("20:30");
            endTimeBox.Items.Add("21:00");
            endTimeBox.Items.Add("21:30");
            endTimeBox.Items.Add("22:00");
            endTimeBox.Items.Add("22:30");
            endTimeBox.Items.Add("23:00");
            endTimeBox.Items.Add("23:30");
            endTimeBox.Items.Add("24:00");

            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Event currentEvent = (Event)eList[EventsList.SelectedIndex];

            Event.updateEvent(textBox1.Text, startTimeBox.Text + ":00", endTimeBox.Text+":00", textBox4.Text, currentEvent.getID(), monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Event currentEvent = (Event)eList[EventsList.SelectedIndex];
                textBox1.Text = currentEvent.getTitle();
                startTimeBox.Text = currentEvent.getStartTime();
                endTimeBox.Text = currentEvent.getEndTime();
                textBox4.Text = currentEvent.getDescription();
            }catch (Exception ex)
            {
                Console.Out.WriteLine(ex.ToString());
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //return table values
            Event currentEvent = (Event)eList[EventsList.SelectedIndex];
            textBox1.Text = currentEvent.getTitle();
            startTimeBox.Text = currentEvent.getStartTime();
            endTimeBox.Text = currentEvent.getEndTime();
            textBox4.Text = currentEvent.getDescription();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Event currentEvent = (Event)eList[EventsList.SelectedIndex];
                DateTime thisDay = DateTime.Today;
                String dateString = thisDay.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                deleteForm delete = new deleteForm(currentEvent.getID(), dateString);
                delete.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            clearText();
            EventsList.Items.Clear();

            thisDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            eList = Event.getEventList(thisDate, ID);
            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                String aString = currentEvent.getStartTime() + "  " + currentEvent.getTitle();
                EventsList.Items.Add(aString);
            }
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            thisDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string dateString = thisDate;

            addEventForm addForm = new addEventForm(dateString);
            addForm.Show();
        }

        //view monthly
        private void button1_Click_2(object sender, EventArgs e)
        {
            Monthly_Events_Form monthlyForm = new Monthly_Events_Form();
            monthlyForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm.loginInstance.Show();
            Close();
        }

        public static void clearText()
        {
            instance1.Text = string.Empty;
            instance2.Text = string.Empty;
            instance3.Text = string.Empty;
            instance4.Text = string.Empty;
        }
    }
}
