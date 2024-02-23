using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int str_index;

        private void button1_Click(object sender, EventArgs e)
        {
            for(int k = 0; k<Class1.count; k++)
            {
                if (textBox1.Text == (string)Class1.userName[k])
                {
                    textBox2.Text = "Enter Your Newpassword";
                    str_index = k;
                    break;
                }
                else
                    textBox1.Text = "Invalid user Name";
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p;
            p = str_index;
            Class1.PassWord[p] = textBox2.Text;
            MessageBox.Show("Password Saved");
        }
    }
}
