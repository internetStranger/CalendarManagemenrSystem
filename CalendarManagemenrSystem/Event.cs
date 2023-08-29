using Google.Protobuf;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalendarManagemenrSystem
{
    internal class Event
    {
        String title;
        String startTime;
        String endTime;
        String date;
        String description;
        int id;

        public Event(String t, String st, String et, String d, String ds, int i)
        {
            title = t;
            startTime = st;
            endTime = et;
            date = d;
            description = ds;
            id = i;
        }

        public Event()
        {

        }

        public static void DeleteEvent(int id)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "DELETE FROM victorgomezevent WHERE eventID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                
                Console.Out.WriteLine(id);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    Console.Out.WriteLine("Event deleted");
                }
                else
                {
                    Console.Out.WriteLine("delete event failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        public static void updateEvent(String t, String st, String et, String d, int i, string date)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "UPDATE victorgomezevent SET Title =@title, StartTime =@sTime, EndTime =@eTime, Description =@desc WHERE eventID =@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", t);
                cmd.Parameters.AddWithValue("@sTime", st);
                cmd.Parameters.AddWithValue("@eTime", et);
                cmd.Parameters.AddWithValue("@desc", d);
                cmd.Parameters.AddWithValue("@id",i);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.Out.WriteLine("Event edited");
                }
                else
                {
                    Console.Out.WriteLine("edit event failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            MainForm.fillList(date);
        }
        public String getStartTime()
        {
            return startTime;
        }

        public string getDate()
        {
            return date.Substring(0, 9);
        }

        public int getID()
        {
            return id;
        }

        public String getEndTime()
        {
            return endTime;
        }

        public String getTitle()
        {
            return title;
        }

        public String getDescription()
        {
            return description;
        }
        public static ArrayList getEventList(string dateString, int id)
        {
            ArrayList eventList = new ArrayList();  //a list to save the events
            DataTable myTable = new DataTable();
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM victorgomezevent WHERE Date =@myDate AND employeeID =@id ORDER BY startTime ASC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@myDate", dateString);
                cmd.Parameters.AddWithValue("@id", id);
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
                Event newEvent = new Event();
                newEvent.title = row["Title"].ToString();
                newEvent.date = row["Date"].ToString();
                newEvent.startTime = row["StartTime"].ToString();
                newEvent.endTime = row["EndTime"].ToString();
                newEvent.description = row["Description"].ToString();
                newEvent.id = (int)row["eventID"];
                eventList.Add(newEvent);
            }
            return eventList;  //return the event list
        }

        public static ArrayList getMonthlyEventList(int id, int month)
        {
            ArrayList eventList = new ArrayList();  //a list to save the events
            DataTable myTable = new DataTable();
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM victorgomezevent WHERE MONTH(Date) = @month AND employeeID = @ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@ID", id);
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
                Event newEvent = new Event();
                newEvent.title = row["Title"].ToString();
                newEvent.date = row["Date"].ToString();
                newEvent.startTime = row["StartTime"].ToString();
                newEvent.endTime = row["EndTime"].ToString();
                newEvent.description = row["Description"].ToString();
                newEvent.id = (int)row["eventID"];
                eventList.Add(newEvent);
            }
            return eventList;  //return the event list
        }

    }
}
