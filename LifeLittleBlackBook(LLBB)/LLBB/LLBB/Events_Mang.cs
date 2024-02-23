using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LLBB.ServiceReference1;
using System.Xml;

namespace LLBB
{
    public partial class Events_Mang : Form
    {
        
        public Events_Mang()
        {
            InitializeComponent();
        }

        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Events_Load(object sender, EventArgs e)
        {
            DD.Open();
            string query = "SELECT * from Events where UserID = '" + UserOut.UserID + "'";
            SqlCommand command = new SqlCommand(query, DD);

            // Execute the query and get the results in a SqlDataReader object
            SqlDataReader reader = command.ExecuteReader();
            //if (ContactClass.count > 0)
            {
                // Iterate over the results and read the data
                while (reader.Read())
                {
                    // Retrieve the data from the reader using the column name or index
                    EventClass.category.Add(reader["Categori"].ToString());
                    EventClass.dayno.Add(reader["Day_No"].ToString());
                    EventClass.monthno.Add(reader["Month_No"].ToString());
                    EventClass.year.Add(reader["Year"].ToString());
                    EventClass.time.Add(reader["time"].ToString());
                    EventClass.count++;
                    //...
                }
            }
            // Close the reader and the connection
            reader.Close();
            if (DD.State == ConnectionState.Closed)
            {
                DD.Open();
            }
            DD.Close();
        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (catgrytxt.Text == "" || dayNotxt.Text == "" || monNotxt.Text == "" || yeartxt.Text == "" || timetxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    {
                        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                        ServiceReference1.BlogEvents Eventedit = new ServiceReference1.BlogEvents();

                        Eventedit.EventCategory = EventClass.category[display].ToString();
                        Eventedit.EventDay = EventClass.dayno[display].ToString();
                        Eventedit.EventMonth = EventClass.monthno[display].ToString();
                        Eventedit.EventYear = EventClass.year[display].ToString();
                        Eventedit.EventTime = EventClass.time[display].ToString();
                        myserver.EditEvent(Eventedit, UserOut.UserID, catgrytxt.Text, dayNotxt.Text, monNotxt.Text, yeartxt.Text, timetxt.Text);

                        for (int i = 0; i < EventClass.count; i++)
                        {
                            if ( (string)EventClass.dayno[i] == dayNotxt.Text || (string)EventClass.monthno[i] == monNotxt.Text || (string)EventClass.year[i] == yeartxt.Text || (string)EventClass.time[i] == timetxt.Text)
                            {
                                EventClass.category[i] = this.catgrytxt.Text;
                                EventClass.dayno[i] = dayNotxt.Text;
                                EventClass.monthno[i] = monNotxt.Text;
                                EventClass.dayno[i] = yeartxt.Text;
                                EventClass.time[i] = timetxt.Text;
                            }
                        }
                        

                        MessageBox.Show("Row updated successfully");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void displaybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calender cal = new Calender();
            cal.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Daily_Diary dd = new Daily_Diary();
            dd.Show();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (catgrytxt.Text == "" || dayNotxt.Text == "" || monNotxt.Text == "" || yeartxt.Text == "" || timetxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {


                    {
                        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                        ServiceReference1.BlogEvents myEvent = new ServiceReference1.BlogEvents();

                        myEvent.EventCategory = catgrytxt.Text;
                        myEvent.EventDay = dayNotxt.Text;
                        myEvent.EventMonth = monNotxt.Text;
                        myEvent.EventYear = yeartxt.Text;
                        myEvent.EventTime = timetxt.Text;
                        myserver.AddEvent(myEvent, UserOut.UserID);

                        EventClass.count++;
                        EventClass.category.Add(catgrytxt.Text.ToString());
                        EventClass.dayno.Add(dayNotxt.Text.ToString());
                        EventClass.monthno.Add(monNotxt.Text.ToString());
                        EventClass.year.Add(yeartxt.Text.ToString());
                        EventClass.time.Add(timetxt.Text.ToString());

                        EventClass.category[EventClass.count - 1] = catgrytxt.Text;
                        EventClass.dayno[EventClass.count - 1] = dayNotxt.Text;
                        EventClass.monthno[EventClass.count - 1] = monNotxt.Text;
                        EventClass.dayno[EventClass.count - 1] = yeartxt.Text;
                        EventClass.time[EventClass.count - 1] = timetxt.Text;


                        if (DD.State == ConnectionState.Closed)
                        {
                            DD.Open();
                        }
                        DD.Close();
                        MessageBox.Show("Row added successfully");
                       

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int display = 0;
        private void Rmvbtn_Click(object sender, EventArgs e)
        {
            if (EventClass.count <= 0)
            {
                MessageBox.Show("NO DATA FOR DELETION");
            }
            else
            {
                ServiceReference1.Service1Client contactserver = new ServiceReference1.Service1Client();
                ServiceReference1.BlogEvents delEvent = new ServiceReference1.BlogEvents();

                delEvent.EventCategory = catgrytxt.Text;
                delEvent.EventDay = dayNotxt.Text;
                delEvent.EventMonth = monNotxt.Text;
                delEvent.EventYear = yeartxt.Text;
                delEvent.EventTime = timetxt.Text;

                contactserver.DeleteEvent(UserOut.UserID, delEvent);

                for (int i = 0; i<EventClass.count;i++)
                {
                    if ((string)EventClass.category[i] == this.catgrytxt.Text && (string)EventClass.dayno[i] == dayNotxt.Text && (string)EventClass.monthno[i] == monNotxt.Text && (string)EventClass.year[i] == yeartxt.Text && (string)EventClass.time[i] == timetxt.Text)
                    {
                        if (i >= 0 && i < EventClass.count - 1)
                        {
                            for (int j = display; j < EventClass.count - 1; j++)
                            {
                                EventClass.category[j] = EventClass.category[j + 1];
                                EventClass.dayno[j] = EventClass.dayno[j + 1];
                                EventClass.monthno[j] = EventClass.monthno[j + 1];
                                EventClass.year[j] = EventClass.year[j + 1];
                                EventClass.time[j] = EventClass.time[j + 1];
                            }
                        }
                    }
                }

                EventClass.count--;

                MessageBox.Show("Row deleted successfully");
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
