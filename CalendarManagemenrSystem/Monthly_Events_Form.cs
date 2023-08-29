using Google.Protobuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarManagemenrSystem
{
    public partial class Monthly_Events_Form : Form
    {

        ArrayList eList;
        public Monthly_Events_Form()
        {
            InitializeComponent();

            MonthList.Items.Add("January");
            MonthList.Items.Add("February");
            MonthList.Items.Add("March");
            MonthList.Items.Add("April");
            MonthList.Items.Add("May");
            MonthList.Items.Add("June");
            MonthList.Items.Add("July");
            MonthList.Items.Add("August");
            MonthList.Items.Add("September");
            MonthList.Items.Add("October");
            MonthList.Items.Add("November");
            MonthList.Items.Add("December");

        }

        

        private void MonthList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //retrieve all events with same MONTH
            //add events to list
            int mon = MonthList.SelectedIndex + 1;
            eList = Event.getMonthlyEventList(MainForm.ID, mon);
            EventList.Items.Clear();
            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                String aString = currentEvent.getDate() + "  " + currentEvent.getTitle();
                EventList.Items.Add(aString);
            }
        }

        private void EventList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Event currentEvent = (Event)eList[EventList.SelectedIndex];
            Console.Out.WriteLine(currentEvent.getDate());

            DateTime date = DateTime.Parse(currentEvent.getDate());
            MainForm.cal.SetDate(date);
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EventsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
