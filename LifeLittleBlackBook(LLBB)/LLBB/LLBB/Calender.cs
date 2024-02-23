using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LLBB
{
    public partial class Calender : Form
    {
        
        int month, year;

        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        private void Prebutn_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            string t = "";
            //decreament month to move to previous month
            month--;

            if (month == 0)
            {
                month = 12;
                year--;
            }

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monyea.Text = monthname + "  " + year;

            // get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 3;

            //first lets create the blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i, t);
                daycontainer.Controls.Add(ucdays);
                for (int j = 0; j < EventClass.count; j++)
                {
                    if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Urgent")
                    {

                        ucdays.BackColor = Color.LightGreen;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                    else if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Wait")
                    {

                        ucdays.BackColor = Color.LightCoral;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                    else if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Personal")
                    {

                        ucdays.BackColor = Color.PeachPuff;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                }
            }
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            string t = "";
            //increament month to move to next month
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monyea.Text = monthname + "  " + year;

            // get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 3;

            //first lets create the blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i, t);
                daycontainer.Controls.Add(ucdays);
                for (int j = 0; j < EventClass.count; j++)
                {
                    if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Urgent")
                    {

                        ucdays.BackColor = Color.LightGreen;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                    else if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Wait")
                    {

                        ucdays.BackColor = Color.LightCoral;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                    else if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Personal")
                    {

                        ucdays.BackColor = Color.PeachPuff;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                }
            }
        }

        public Calender()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Calender_Load(object sender, EventArgs e)
        {
            
            diaplaDays();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Events_Mang EM = new Events_Mang();
            EM.Show();
        }

        private void diaplaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string t = "";

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monyea.Text = monthname + "  " + year;

            //Lets get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 3;

            //first lets create the blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();

                ucdays.days(i, t);
                daycontainer.Controls.Add(ucdays);
                for (int j = 0; j < EventClass.count; j++)
                {
                    if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Urgent")
                    {

                        ucdays.BackColor = Color.LightGreen;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                    else if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Wait")
                    {

                        ucdays.BackColor = Color.LightCoral;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                    else if (i.ToString() == (string)EventClass.dayno[j] && month.ToString() == (string)EventClass.monthno[j] && year.ToString() == (string)EventClass.year[j] && (string)EventClass.category[j] == "Personal")
                    {

                        ucdays.BackColor = Color.PeachPuff;
                        ucdays.days(i, (string)EventClass.time[j]);
                        daycontainer.Controls.Add(ucdays);
                    }
                }

            }



        }

    }
}
