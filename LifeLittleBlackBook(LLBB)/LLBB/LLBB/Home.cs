using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using LLBB.ServiceReference1;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLBB
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
            ServiceReference1.BlogUser user = new ServiceReference1.BlogUser();

            user.UserUName = UserOut.UserID;
            user.UserPassword = UserOut.PassWord;

            server.DeleteUser(user);
            MessageBox.Show("Logout successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Book contbook = new Contact_Book();
            contbook.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Budget bud = new Budget();
            bud.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Daily_Diary Daldia = new Daily_Diary();
            Daldia.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
