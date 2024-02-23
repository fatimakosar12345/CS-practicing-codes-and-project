using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LLBB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        bool choose = true;
        private void button3_Click(object sender, EventArgs e)
        {
            DD.Open();

            // Create a SqlCommand object to execute a query
            string query = "SELECT * FROM UserData";
            SqlCommand command = new SqlCommand(query, DD);

            // Execute the query and get the results in a SqlDataReader object
            SqlDataReader reader = command.ExecuteReader();

            // Iterate over the results and read the data
            while (reader.Read())
            {
                // Retrieve the data from the reader using the column name or index
                User.userID.Add(reader["UserID"].ToString());
                User.userName.Add(reader["UserName"].ToString());
                User.PassWord.Add(reader["Password"].ToString());
                User.count = User.count + 1;

                //...
            }

            // Close the reader and the connection
            reader.Close();
            DD.Close();
            for (int i = 0; i < User.count; i++)
            {
                if (Unametxt.Text == (string)User.userName[i] && passtxt.Text == (string)User.PassWord[i])
                {
                    UserOut.UserID = (string)User.userID[i];
                    UserOut.UserName = (string)User.userName[i];
                    UserOut.PassWord = (string)User.PassWord[i];
                    choose = true;

                    this.Hide();
                    Home hom = new Home();
                    hom.Show();
                    break;
                }
                else
                {
                    choose = false;
                }
            }
            if(choose == false)
                MessageBox.Show("Enter valid User Name or Password");
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Unametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }
    }
}
