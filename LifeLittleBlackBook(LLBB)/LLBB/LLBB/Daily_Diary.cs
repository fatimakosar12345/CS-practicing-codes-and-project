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
    public partial class Daily_Diary : Form
    {
        public Daily_Diary()
        {
            InitializeComponent();
        }

        private void DNotebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notes not = new Notes();
            not.Show();
        }

        private void MemPicbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mem_Pics mempic = new Mem_Pics();
            mempic.Show();
        }

        private void EMangbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events_Mang eman = new Events_Mang();
            eman.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void Daily_Diary_Load(object sender, EventArgs e)
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
