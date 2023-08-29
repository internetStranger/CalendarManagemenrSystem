using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using static System.Windows.Forms.AxHost;


namespace CalendarManagemenrSystem
{
    public partial class loginForm : Form
    {

        public static loginForm loginInstance;

        ArrayList eList;

        public loginForm()
        {
            InitializeComponent();

            loginInstance= this;

            eList = Employee.getEmployeeList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ErrorMessage.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < eList.Count; i++)
            {
                Employee currentEmployee = (Employee)eList[i];
                if (usernameBox.Text == currentEmployee.getUserName())
                {
                    if(passwordBox.Text == currentEmployee.getPassword())
                    {

                        MainForm main = new MainForm(currentEmployee.getId());
                        main.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        ErrorMessage.Text = "Incorrect UserName or Password";
                    }
                }
                else
                {
                    ErrorMessage.Text = "Incorrect UserName or Password";
                }
            }
            ErrorMessage.Show();

        }
    }
}
