using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasks_lab_3
{
    public partial class Form2 : Form
    {
        private ServiceReference4.Blogpost show;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ServiceReference4.Blogpost postt)
        {
           InitializeComponent();
            show = postt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = show.PostTitle;
            label2.Text = show.PostDescription;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
