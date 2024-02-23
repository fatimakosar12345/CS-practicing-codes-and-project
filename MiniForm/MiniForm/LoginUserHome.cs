using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_tasks
{
    public partial class LoginUserHome : Form
    {
        public LoginUserHome()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Student mystudent in datastore.data)
            {
                ctluserDisplay ctl1 = new ctluserDisplay(mystudent.ImagePath, mystudent.UserName);
                flowLayoutPanel1.Controls.Add(ctl1);

                if(textBox1.Text == mystudent.UserName)
                {
                    pictureBox1.Load(mystudent.ImagePath);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 signup = new Form1();
            signup.Show();
        }
    }
}
