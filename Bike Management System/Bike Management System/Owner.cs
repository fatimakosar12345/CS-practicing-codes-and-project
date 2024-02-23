using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Management_System
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        SqlConnection Shr = new SqlConnection(@"Data Source=DESKTOP-V788FUV;Initial Catalog=Bike_Management_System;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void displayShow()
        {
            Shr.Open();
            string Query = "select * from Showroom";
            SqlDataAdapter dbs = new SqlDataAdapter(Query, Shr);
            SqlCommandBuilder builder = new SqlCommandBuilder(dbs);
            var ds = new DataSet();
            dbs.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Shr.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (ownerIDtxt.Text == "" || nametxt.Text == "" || showIDtxt.Text == "" || showtxt.Text == "" || agetxt.Text == "" || gendercombo.Text == "" || dobtxt.Text == "" || addresstxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Shr.Open();
                    SqlCommand cmd = new SqlCommand("insert into Showroom(name, IDNo, showroom, s_roomID, address, gender, phoneNo, DOB, age,) values(@ON,@IDN,@SN,@SID,@OAD,@OG,@PN,@ODOB,@OA)", Shr);
                    cmd.Parameters.AddWithValue("@IDN", ownerIDtxt.Text);
                    cmd.Parameters.AddWithValue("@ON", nametxt.Text);
                    cmd.Parameters.AddWithValue("@SID", showIDtxt.Text);
                    cmd.Parameters.AddWithValue("@SN", showtxt.Text);
                    cmd.Parameters.AddWithValue("@PN", phonetxt.Text);
                    cmd.Parameters.AddWithValue("@OA", agetxt.Text);
                    cmd.Parameters.AddWithValue("@OG", gendercombo.Text);
                    cmd.Parameters.AddWithValue("@ODOB", dobtxt.Text);
                    cmd.Parameters.AddWithValue("@OAD", addresstxt.Text);
                    cmd.ExecuteNonQuery();
                    Shr.Close();
                    MessageBox.Show("Record added successfully");
                    displayShow();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;

        private void gendercombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ownerIDtxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            showIDtxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            showtxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            phonetxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            agetxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            gendercombo.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dobtxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            addresstxt.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            if (showIDtxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Shr.Open();
            SqlCommand cmd = Shr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Showroom where s_roomID='" + showIDtxt.Text + "'";
            cmd.ExecuteNonQuery();
            Shr.Close();
            MessageBox.Show("Record deleted successfully");
            displayShow();
        }
    }
}
