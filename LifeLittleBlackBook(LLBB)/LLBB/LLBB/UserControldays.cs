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
    public partial class UserControldays : UserControl
    {
        public UserControldays()
        {
            InitializeComponent();
        }

        private void UserControldays_Load(object sender, EventArgs e)
        {

        }

        public void days(int monday, string time)
        {
            label1.Text = monday + "";
            label2.Text = time;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
