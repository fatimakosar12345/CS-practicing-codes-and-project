using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using LLBB.ServiceReference1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace LLBB
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }

        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");
        private void display_Load(object sender, EventArgs e)
        {
            DD.Open();
            string query = "SELECT Datee,Day,Notes FROM Diary where UserID = '" + UserOut.UserID + "'";
            SqlCommand command = new SqlCommand(query, DD);

            // Execute the query and get the results in a SqlDataReader object
            //if(NotesClass.count<=0)
            //{
                SqlDataReader reader = command.ExecuteReader();
                //if (ContactClass.count > 0)
                {
                    // Iterate over the results and read the data
                    while (reader.Read())
                    {
                        // Retrieve the data from the reader using the column name or index
                        NotesClass.count++;
                        NotesClass.Date.Add(reader["Datee"].ToString());
                        NotesClass.Day.Add(reader["Day"].ToString());
                        NotesClass.Note.Add(reader["Notes"].ToString());
                        //...
                    }
                }
                // Close the reader and the connection
                reader.Close();
            //}
            if (DD.State == ConnectionState.Closed)
            {
                DD.Open();
            }
            DD.Close();
            if (NotesClass.count > 0)
            {
                datetxt.Text = (string)NotesClass.Date[Display];
                daytxt.Text = (string)NotesClass.Day[Display];
                notetxt.Text = (string)NotesClass.Note[Display];
            }
            else
            {

                Textlabel.Text = "No data Record";

                daytxt.Text = "";
                datetxt.Text = "";
                notetxt.Text = "";

                daylabel.Text = "";
                datelabel.Text = "";
                notelabel.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (NotesClass.count <= 0)
            {
                Textlabel.Text = "No more data for deletion";
                daytxt.Text = "";
                datetxt.Text = "";
                notetxt.Text = "";
                
                daylabel.Text = "";
                datelabel.Text = "";
                notelabel.Text = "";
            }
            else
            {
                ServiceReference1.Service1Client contactserver = new ServiceReference1.Service1Client();
                ServiceReference1.BlogNotes notes = new ServiceReference1.BlogNotes();

                notes.NotesDate = datetxt.Text;
                notes.NotesDay = daytxt.Text;
                notes.Notesnotes = notetxt.Text;

                contactserver.DeleteNotes(UserOut.UserID, notes);

                if (Display >= 0 && Display < NotesClass.count - 1)
                {
                    
                    datetxt.Text = (string)NotesClass.Date[Display + 1];
                    daytxt.Text = (string)NotesClass.Day[Display + 1];
                    notetxt.Text = (string)NotesClass.Note[Display + 1];

                }
                else if (Display == NotesClass.count - 1 && NotesClass.count >= 2)
                {
                    
                    datetxt.Text = (string)NotesClass.Date[Display - 1];
                    daytxt.Text = (string)NotesClass.Day[Display - 1];
                    notetxt.Text = (string)NotesClass.Note[Display - 1];

                }
                else if (Display == 0 && NotesClass.count == 1)
                {
                    
                    datetxt.Text = "";
                    daytxt.Text = "";
                    notetxt.Text = "";

                }
                if (Display >= 0 && Display < NotesClass.count - 1)
                {
                    for (int j = Display; j < NotesClass.count - 1; j++)
                    {
                        NotesClass.Date[j] = NotesClass.Date[j + 1];
                        NotesClass.Day[j] = NotesClass.Day[j + 1];
                        NotesClass.Note[j] = NotesClass.Note[j + 1];
           
                    }
                }

                NotesClass.count--;

                MessageBox.Show("Row deleted successfully");
            }
        }
        int Display = 0;

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            if (NotesClass.count > 0)
            {
                Display--;
                if (Display < 0)
                {
                    Display = NotesClass.count - 1;
                }
                datetxt.Text = (string)NotesClass.Date[Display];
                daytxt.Text = (string)NotesClass.Day[Display];
                notetxt.Text = (string)NotesClass.Note[Display];
                
                // display = i;
            }
            else
            {
                Textlabel.Text = "No data Record";

                daytxt.Text = "";
                datetxt.Text = "";
                notetxt.Text = "";

                daylabel.Text = "";
                datelabel.Text = "";
                notelabel.Text = "";
            }
            
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (NotesClass.count > 0)
            {
                Display++;
                if (Display >= NotesClass.count)
                {
                    Display = 0;
                }
                datetxt.Text = (string)NotesClass.Date[Display];
                daytxt.Text = (string)NotesClass.Day[Display];
                notetxt.Text = (string)NotesClass.Note[Display];

                // display = i;
            }
            else
            {
                Textlabel.Text = "No data Record";

                daytxt.Text = "";
                datetxt.Text = "";
                notetxt.Text = "";

                daylabel.Text = "";
                datelabel.Text = "";
                notelabel.Text = "";
            }
            
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (datetxt.Text == "" || daytxt.Text == "" || notetxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    {
                        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                        ServiceReference1.BlogNotes notesedit = new ServiceReference1.BlogNotes();

                        notesedit.NotesDay = NotesClass.Day[Display].ToString();
                        notesedit.NotesDate = NotesClass.Date[Display].ToString();
                        notesedit.Notesnotes = NotesClass.Note[Display].ToString();
                        
                        myserver.EditNotes(notesedit, UserOut.UserID, datetxt.Text,daytxt.Text,notetxt.Text);

                        NotesClass.Date[Display] = datetxt.Text;
                        NotesClass.Day[Display] = daytxt.Text;
                        NotesClass.Note[Display] = notetxt.Text;
                       
                        MessageBox.Show("Row updated successfully");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Notes n = new Notes();
            n.Show();
        }
    }
}
