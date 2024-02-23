using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace LLBB
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool choose = true;
            for (int i = 0; i < User.count; i++)
            {
                if (Unametxt.Text == (string)User.userName[i] && passtxt.Text == (string)User.PassWord[i])
                {
                    
                    UserOut.UserName = (string)User.userName[i];
                    UserOut.PassWord = (string)User.PassWord[i];
                    UserOut.UserID = (string)User.userID[i];
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
            if (choose == false)
                MessageBox.Show("Enter valid User Name or Password");
           
        }

        private void Login1_Load(object sender, EventArgs e)
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
