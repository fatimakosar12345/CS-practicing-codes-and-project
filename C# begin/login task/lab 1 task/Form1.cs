using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string username1 = "pakistan";
        string password1 = "1234";
        string username2 = "cse";
        string password2 = "17";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username1 && textBox2.Text == password1)
            {
                label3.BackColor= System.Drawing.Color.Green;
                label3.Text = "Valid User";
                MessageBox.Show("Login Successfully");
            }
            else if (textBox1.Text == username2 && textBox2.Text == password2)
            {
                label3.BackColor = System.Drawing.Color.Green;
                label3.Text = "Valid User";
                MessageBox.Show("Login Successfully");
            }
            else
            {
                label3.BackColor = System.Drawing.Color.Red;
                label3.Text = "InValid User";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
