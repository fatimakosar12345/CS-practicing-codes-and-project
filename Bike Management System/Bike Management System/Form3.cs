using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showroomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 showroom= new Form4();
            showroom.Show();
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            owner.Show();
        }
    }
}
