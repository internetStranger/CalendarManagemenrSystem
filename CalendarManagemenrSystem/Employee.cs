using Google.Protobuf;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarManagemenrSystem
{
    internal class Employee
    {
        int Id;
        String UserName;
        String Password;

        public Employee(String u, String p, int i)
        {
            UserName= u;
            Password= p;
            Id= i;
        }

        public Employee() 
        {

        }

        public String getUserName()
        {
            return UserName;
        }
        public String getPassword()
        {
            return Password;
        }
        public int getId()
        {
            return Id;
        }

        public static ArrayList getEmployeeList()
        {
            ArrayList employeeList = new ArrayList();  //a list to save the events
            DataTable myTable = new DataTable();
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM victorgomezemployee";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //convert the retrieved data to events and save them to the list
            foreach (DataRow row in myTable.Rows)
            {
                Employee newEmployee = new Employee();
                newEmployee.Id = (int)row["ID"];
                newEmployee.UserName = row["Username"].ToString();
                newEmployee.Password = row["Password"].ToString();
                employeeList.Add(newEmployee);
            }
            return employeeList;  //return the employee list
        }



    }
}
