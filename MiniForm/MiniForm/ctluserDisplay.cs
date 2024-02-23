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
    public partial class ctluserDisplay : UserControl
    {
        public ctluserDisplay(string picturepath, string username)
        {
            InitializeComponent();
            linkLabel1.Text = username;
            pictureBox1.Load(picturepath);
        }

        private void ctluserDisplay_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
