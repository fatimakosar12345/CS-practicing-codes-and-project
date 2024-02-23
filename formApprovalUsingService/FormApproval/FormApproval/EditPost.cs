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
    public partial class EditPost : Form
    {
        private ServiceReference4.Blogpost editpost = new ServiceReference4.Blogpost();
        private ServiceReference4.Service1Client server = new ServiceReference4.Service1Client();
        int index;
        public EditPost()
        {
            InitializeComponent();
        }

        public EditPost(ServiceReference4.Blogpost post, int a)
        {
            InitializeComponent();
            editpost = post;
            index = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editpost.PostTitle = textBox1.Text;
            editpost.PostDescription = textBox2.Text;
            editpost.PostApproved = checkBox1.Checked;
            server.Deletepost(index);
            server.savepost(editpost, index);
            this.Close();
            Form1 firstform = new Form1();
            firstform.Show();
        }

        private void EditPost_Load(object sender, EventArgs e)
        {
            textBox1.Text = editpost.PostTitle;
            textBox2.Text = editpost.PostDescription;
            checkBox1.Checked = editpost.PostApproved;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
