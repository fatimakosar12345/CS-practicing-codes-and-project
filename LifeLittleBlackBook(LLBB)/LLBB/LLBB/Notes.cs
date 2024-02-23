using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLBB.ServiceReference1;
using System.Xml;
using System.Xml.Linq;

namespace LLBB
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Notes_Load(object sender, EventArgs e)
        {
            
        }
        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        //void getIncreamentID()
        //{
        //    string query = "select DiaryID from Diary";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, DD);
        //    DataTable data = new DataTable();
        //    sda.Fill(data);
        //    if (data.Rows.Count < 1)
        //    {
        //        NIDtxt.Text = "1";
        //    }
        //    else
        //    {
        //        string query1 = "select max(DiaryID) from Diary";
        //        SqlCommand cmd = new SqlCommand(query1, DD);
        //        DD.Open();
        //        int a = Convert.ToInt32(cmd.ExecuteScalar());
        //        if (DD.State == ConnectionState.Closed)
        //        {
        //            DD.Open();
        //        }
        //        DD.Close();

        //        a = a + 1;
        //        NIDtxt.Text = a.ToString();
        //    }
        //}


        private void addbtn_Click(object sender, EventArgs e)
        {
            if (Daytxt.Text == "" || Dattxt.Text == "" || Notetxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {


                    {
                        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                        ServiceReference1.BlogNotes mynote = new ServiceReference1.BlogNotes();

                        mynote.NotesDate = Dattxt.Text;
                        mynote.NotesDay = Daytxt.Text;
                        mynote.Notesnotes = Notetxt.Text;
                        
                        myserver.AddNotes(mynote, UserOut.UserID);

                        NotesClass.count++;
                        NotesClass.Date.Add(Dattxt.Text.ToString());
                        NotesClass.Day.Add(Daytxt.Text.ToString());
                        NotesClass.Note.Add(Notetxt.Text.ToString());

                        NotesClass.Date[NotesClass.count - 1] = Dattxt.Text;
                        NotesClass.Day[NotesClass.count - 1] = Daytxt.Text;
                        NotesClass.Note[NotesClass.count - 1] = Notetxt.Text;
                        

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

        
        private void disbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            display dis = new display();
            dis.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Daily_Diary DD= new Daily_Diary();
            DD.Show();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
