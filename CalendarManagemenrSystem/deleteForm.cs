using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarManagemenrSystem
{
    public partial class deleteForm : Form
    {
        int eventId;
        string date;

        public deleteForm()
        {
            InitializeComponent();
        }

        public deleteForm(int i, string d)
        {
            eventId = i;
            date = d;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sql code - delete event
            Event.DeleteEvent(eventId);
            MainForm.clearText();
            MainForm.fillList(date);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
