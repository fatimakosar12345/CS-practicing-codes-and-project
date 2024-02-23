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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataGridViewLinkColumn lnk = new DataGridViewLinkColumn();
            dataGridView1.Columns.Add(lnk);
            lnk.HeaderText = "Delete data";
            lnk.Text = "Delete";
            lnk.UseColumnTextForLinkValue = true;
            datashow();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference4.Service1Client myserver = new ServiceReference4.Service1Client();
            ServiceReference4.Blogpost mypost = new ServiceReference4.Blogpost();
            mypost.PostTitle = textBox1.Text;
            mypost.PostDescription = richTextBox1.Text;
            mypost.PostApproved = checkBox1.Checked;
            myserver.addPost(mypost);
            datashow();
        }

        public void datashow()
        {
            ServiceReference4.Service1Client myClient = new ServiceReference4.Service1Client();
            BindingSource abc = new BindingSource();
            abc.DataSource = myClient.getPostlist();
            dataGridView1.DataSource = abc;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceReference4.Service1Client myserver = new ServiceReference4.Service1Client();

            if(e.ColumnIndex == 0)
            {
                ServiceReference4.Blogpost post = myserver.getPost(e.RowIndex);
                Form2 abc = new Form2();
                abc.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datashow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference4.Service1Client server = new ServiceReference4.Service1Client();
                server.Deletepost(this.dataGridView1.SelectedRows[0].Index);
                datashow();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference4.Service1Client server = new ServiceReference4.Service1Client();
                ServiceReference4.Blogpost mypost = new ServiceReference4.Blogpost();
                int index = this.dataGridView1.SelectedRows[0].Index;
                mypost = server.getPost(index);
                EditPost editpost = new EditPost();
                editpost.Show();
            }
        }

        private void txtPosttitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "enter post title");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void txtPosttitle_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, null);
        }
    }
}
