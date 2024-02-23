using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace LLBB
{
    public partial class Contact_Book : Form
    {
        public Contact_Book()
        {
            InitializeComponent();
        }

        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        //void getIncreamentID()
        //{
        //    string query = "select ContactID from ContactBook";
        //    SqlDataAdapter sda = new SqlDataAdapter(query,DD);
        //    DataTable data = new DataTable();
        //    sda.Fill(data);
        //    if(data.Rows.Count < 1)
        //    {
        //        CIDtxt.Text = "1";
        //    }
        //    else
        //    {
        //        string query1 = "select max(ContactID) from ContactBook";
        //        SqlCommand cmd = new SqlCommand(query1, DD);
        //        DD.Open();
        //        int a = Convert.ToInt32(cmd.ExecuteScalar());
        //        if (DD.State == ConnectionState.Closed)
        //        {
        //            DD.Open();
        //        }
        //        DD.Close();
                
        //        a = a + 1;
        //        CIDtxt.Text = a.ToString();
               
        //    }
        //}

       


        private void button2_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || phone.Text == "" || address.Text == "" || day.Text == "" || date.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {  
                    
                    
                    {
                        DD.Open();
                        SqlCommand cmd = new SqlCommand("insert into ContactBook(UserID,Name,PhoneNo,Address,Day,Datee) values(@UID,@N,@PN,@AD,@D,@DAT)", DD);
                        
                        cmd.Parameters.AddWithValue("@UID", UserOut.UserID);
                        cmd.Parameters.AddWithValue("@N", name.Text);
                        cmd.Parameters.AddWithValue("@PN", phone.Text);
                        cmd.Parameters.AddWithValue("@AD", address.Text);
                        cmd.Parameters.AddWithValue("@D", day.Text);
                        cmd.Parameters.AddWithValue("@DAT", date.Text);

                        cmd.ExecuteNonQuery();

                        Textlabel.Text = "";

                        namelabel.Text = "Name";
                        phonelabel.Text = "Phone No";
                        addresslabel.Text = "Address";
                        daylabel.Text = "Day";
                        datelabel.Text = "Date";
                        nametxt.Text = name.Text;
                        phonetxt.Text = phone.Text;
                        addresstxt.Text = address.Text;
                        daytxt.Text = day.Text;
                        datetxt.Text = date.Text;

                        ContactClass.count++;
                        ContactClass.Name.Add(name.Text.ToString());
                        ContactClass.PhoneNo.Add(phone.Text.ToString());
                        ContactClass.Address.Add(address.Text.ToString());
                        ContactClass.Day.Add(day.Text.ToString());
                        ContactClass.Date.Add(date.Text.ToString());

                        if (DD.State == ConnectionState.Closed)
                        {
                            DD.Open();
                        }
                        DD.Close();
                        MessageBox.Show("Row added successfully");
                        for(int i = 0;i<ContactClass.count;i++)
                        {
                            MessageBox.Show(ContactClass.Name[i].ToString());
                        }
                        
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Delbtn_Click(object sender, EventArgs e)
        {

            if (ContactClass.count <= 0)
            {
                Textlabel.Text = "No more data for deletion";
                nametxt.Text = "";
                phonetxt.Text = "";
                addresstxt.Text = "";
                daytxt.Text = "";
                datetxt.Text = "";

                namelabel.Text = "";
                phonelabel.Text = "";
                addresslabel.Text = "";
                daylabel.Text = "";
                datelabel.Text = "";
                Textlabel.Text = "";
            }
            else
            {
                DD.Open();
                SqlCommand cmd1 = DD.CreateCommand();
                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "delete from ContactBook where UserID = '" + UserOut.UserID + "' and Name='" + nametxt.Text + "' and PhoneNo='" + phonetxt.Text + "' and Address = '" + addresstxt.Text + "' and Day='" + daytxt.Text + "' and Datee='" + datetxt.Text + "'";

                cmd1.ExecuteNonQuery();
                DD.Close();

                if (display >= 0 && display < ContactClass.count - 1)
                {
                    nametxt.Text = (string)ContactClass.Name[display + 1];
                    phonetxt.Text = (string)ContactClass.PhoneNo[display + 1];
                    addresstxt.Text = (string)ContactClass.Address[display + 1];
                    daytxt.Text = (string)ContactClass.Day[display + 1];
                    datetxt.Text = (string)ContactClass.Date[display + 1];

                }
                else if (display == ContactClass.count - 1 && ContactClass.count >= 2)
                {
                    nametxt.Text = (string)ContactClass.Name[display - 1];
                    phonetxt.Text = (string)ContactClass.PhoneNo[display - 1];
                    addresstxt.Text = (string)ContactClass.Address[display - 1];
                    daytxt.Text = (string)ContactClass.Day[display - 1];
                    datetxt.Text = (string)ContactClass.Date[display - 1];

                }
                else if (display == 0 && ContactClass.count == 1)
                {
                    nametxt.Text = "";
                    phonetxt.Text = "";
                    addresstxt.Text = "";
                    daytxt.Text = "";
                    datetxt.Text = "";

                }
                if (display >= 0 && display < ContactClass.count - 1)
                {
                    for (int j = display; j < ContactClass.count - 1; j++)
                    {
                        ContactClass.Name[j] = ContactClass.Name[j + 1];
                        ContactClass.PhoneNo[j] = ContactClass.PhoneNo[j + 1];
                        ContactClass.Address[j] = ContactClass.Address[j + 1];
                        ContactClass.Day[j] = ContactClass.Day[j + 1];
                        ContactClass.Date[j] = ContactClass.Date[j + 1];
                    }
                }

                ContactClass.count--;

                MessageBox.Show("Row deleted successfully");
            }
            
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || phone.Text == "" || address.Text == "" || day.Text == "" || date.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    {
                        DD.Open();
                        SqlCommand cmd = new SqlCommand("update ContactBook set UserID=@UID,Name=@N,PhoneNo=@PN,Address=@AD,Day=@D,Datee=@DAT where UserID=@UID and ContactID='"+display+1+"'", DD);
                        cmd.Parameters.AddWithValue("@UID", UserOut.UserID);
                        cmd.Parameters.AddWithValue("@N", name.Text);
                        cmd.Parameters.AddWithValue("@PN", phone.Text);
                        cmd.Parameters.AddWithValue("@AD", address.Text);
                        cmd.Parameters.AddWithValue("@D", day.Text);
                        cmd.Parameters.AddWithValue("@DAT", date.Text);

                        cmd.ExecuteNonQuery();
                        DD.Close();
                        MessageBox.Show("Row updated successfully");
                       
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //int i = 0;
        int display = 0;
        private void Contact_Book_Load(object sender, EventArgs e)
        {
           
            
            DD.Open();
            string query = "SELECT Name,PhoneNo,Address,Day,Datee FROM ContactBook where UserID = '"+UserOut.UserID+"'";
            SqlCommand command = new SqlCommand(query, DD);

            // Execute the query and get the results in a SqlDataReader object
            SqlDataReader reader = command.ExecuteReader();
            //if (ContactClass.count > 0)
            {
                // Iterate over the results and read the data
                while (reader.Read())
                {
                    // Retrieve the data from the reader using the column name or index
                    ContactClass.Name.Add(reader["Name"].ToString());
                    ContactClass.PhoneNo.Add(reader["PhoneNo"].ToString());
                    ContactClass.Address.Add(reader["Address"].ToString());
                    ContactClass.Day.Add(reader["Day"].ToString());
                    ContactClass.Date.Add(reader["Datee"].ToString());
                    ContactClass.count ++;
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
            if (ContactClass.count > 0)
            {
                nametxt.Text = (string)ContactClass.Name[display];
                phonetxt.Text = (string)ContactClass.PhoneNo[display];
                addresstxt.Text = (string)ContactClass.Address[display];
                daytxt.Text = (string)ContactClass.Day[display];
                datetxt.Text = (string)ContactClass.Date[display];   
            }
            else
            {
                nametxt.Text = "";
                phonetxt.Text = "";
                addresstxt.Text = "";
                daytxt.Text = "";
                datetxt.Text = "";

                namelabel.Text = "";
                phonelabel.Text = "";
                addresslabel.Text = "";
                daylabel.Text = "";
                datelabel.Text = "";
                Textlabel.Text = "No data Record";
            }
            //display = i;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Addres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void day_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayContact dc = new DisplayContact();
            dc.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            if (ContactClass.count > 0)
            {
                display--;
                if (display < 0)
                {
                    display = ContactClass.count - 1;
                }
                nametxt.Text = (string)ContactClass.Name[display];
                phonetxt.Text = (string)ContactClass.PhoneNo[display];
                addresstxt.Text = (string)ContactClass.Address[display];
                daytxt.Text = (string)ContactClass.Day[display];
                datetxt.Text = (string)ContactClass.Date[display];
               // display = i;
            }
            else
            {
                Textlabel.Text = "No data Record";

                nametxt.Text = "";
                phonetxt.Text = "";
                addresstxt.Text = "";
                daytxt.Text = "";
                datetxt.Text = "";

                namelabel.Text = "";
                phonelabel.Text = "";
                addresslabel.Text = "";
                daylabel.Text = "";
                datelabel.Text = "";
            }
            int s = ContactClass.count;
            counttxt.Text = s.ToString();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (ContactClass.count > 0)
            {
                display++;
                if (display >= ContactClass.count)
                {
                    display = 0;
                }
                nametxt.Text = (string)ContactClass.Name[display];
                phonetxt.Text = (string)ContactClass.PhoneNo[display];
                addresstxt.Text = (string)ContactClass.Address[display];
                daytxt.Text = (string)ContactClass.Day[display];
                datetxt.Text = (string)ContactClass.Date[display];
                //display = i;
            }
            else
            {
                Textlabel.Text = "No data Record";

                nametxt.Text = "";
                phonetxt.Text = "";
                addresstxt.Text = "";
                daytxt.Text = "";
                datetxt.Text = "";

                namelabel.Text = "";
                phonelabel.Text = "";
                addresslabel.Text = "";
                daylabel.Text = "";
                datelabel.Text = "";
            }
             
            int s = ContactClass.count;
            counttxt.Text = s.ToString();
        }

        private void datetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
