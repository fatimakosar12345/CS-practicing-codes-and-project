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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fPath;
        System.Drawing.Image fs;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\Users\\FATIMA\\Pictures";
            fileDialog.Title = "Choose Image file";
            fileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                fPath = fileDialog.FileName;
                fs = Image.FromFile(fPath);
                pictureBox1.Image = fs;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String extension = System.IO.Path.GetExtension(fPath);
            String fileName = textBox1.Text;
            String path = System.IO.Directory.GetCurrentDirectory();
            String pathWithName = System.IO.Path.Combine(path, fileName);

            fs.Save(pathWithName);

            Student std = new Student();
            std.UserName = textBox1.Text;
            std.PassWord = textBox2.Text;
            std.SelectAge = textBox3.Text;
            std.ImagePath = pathWithName;

            if(radioButton1.Checked)
            {
                std.SelectGender = "Male";
            }
            else
            {
                if(radioButton2.Checked)
                {
                    std.SelectGender = "Female";
                }
            }

            datastore.data.Add(std);
            MessageBox.Show("SignUp Successfully");
            Form2 login = new Form2();
            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fPath;
            System.Drawing.Image fs;
            Form2 login = new Form2();
            login.Show();
        }
    }
}
