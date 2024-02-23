using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLBB
{
    public partial class Mem_Pics : Form
    {
        public Mem_Pics()
        {
            InitializeComponent();
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select multiple images";
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            DialogResult dr = ofd.ShowDialog();
            if(dr == System.Windows.Forms.DialogResult.OK)
            {
                string []files = ofd.FileNames;
                int x = 20;
                int y = 20;
                int maxHeight = -1;
                foreach(string img in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.CenterImage;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    x += pic.Width + 200;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if(x > this.ClientSize.Width - 100)
                    {
                        x = 200;
                        y += maxHeight + 200;
                    }
                    this.flowLayoutPanel1.Controls.Add(pic);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dattxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
