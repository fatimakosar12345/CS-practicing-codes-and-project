using LLBB.Properties;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using LLBB.ServiceReference1;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace LLBB
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        SqlConnection DD=new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        void display()
        {
            DD.Open();

            // Create a SqlCommand object to execute a query
            string query = "SELECT UserID FROM UserData";
            SqlCommand command = new SqlCommand(query, DD);

            // Execute the query and get the results in a SqlDataReader object
            SqlDataReader reader = command.ExecuteReader();

            // Iterate over the results and read the data
            while (reader.Read())
            {
                // Retrieve the data from the reader using the column name or index
                
                MessageBox.Show(reader["UserID"].ToString());
          
                //...
            }

            // Close the reader and the connection
            reader.Close();
            DD.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Ftext.Text == "" || Ltext.Text == "" || Utext.Text == "" || Atext.Text == "" || Dtext.Text == "" || Ptext.Text == "" || CPtext.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            if (Ptext.Text != CPtext.Text)
            {
                MessageBox.Show("Password and confirm password should be same");
            }
            else 
            {
                try
                {
                    ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                    ServiceReference1.BlogUser myuser = new ServiceReference1.BlogUser();

                    myuser.UserFName = Ftext.Text;
                    myuser.UserLName = Ltext.Text;
                    myuser.UserUName = Utext.Text;
                    myuser.UserAddress = Atext.Text;
                    myuser.UserDOB = Dtext.Text;
                    myuser.UserPassword = Ptext.Text;
                    myuser.UserCPassword = CPtext.Text;
                    myserver.AddUser(myuser);

                    DD.Open();
                    string query = "SELECT UserID,UserNAme,Password FROM UserData";
                        SqlCommand command = new SqlCommand(query, DD);

                        // Execute the query and get the results in a SqlDataReader object
                        SqlDataReader reader = command.ExecuteReader();
                        string loginID = "";
                        // Iterate over the results and read the data
                        while (reader.Read())
                        {
                            // Retrieve the data from the reader using the column name or index
                            User.userID.Add(reader["UserID"].ToString());
                            User.userName.Add(reader["UserName"].ToString());
                            User.PassWord.Add(reader["Password"].ToString());
                            User.count = User.count + 1;

                            loginID = reader["UserID"].ToString();
                            //...
                        }

                    // Close the reader and the connection
                    reader.Close();
                    UserOut.UserID = loginID;
                    
                    DD.Close();
                    this.Hide();
                    Login log = new Login();
                        log.Show();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
    
}
