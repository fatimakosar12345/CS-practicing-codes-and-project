using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bike_Management_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            displayShow();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        SqlConnection Shr = new SqlConnection(@"Data Source=DESKTOP-V788FUV;Initial Catalog=Bike_Management_System;Integrated Security=True");

        private void displayShow()
        {
            Shr.Open();
            string Query = "select * from Showroom";
            SqlDataAdapter dbs = new SqlDataAdapter(Query,Shr);
            SqlCommandBuilder builder = new SqlCommandBuilder(dbs);
            var ds = new DataSet();
            dbs.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Shr.Close();
        }
        private void addbtn_Click_1(object sender, EventArgs e)
        {
            if (showIDtxt.Text == "" || nametxt.Text == "" || ownertxt.Text == "" || managertxt.Text == "" || contacttxt.Text == "" || branchtxt.Text == "" || addresstxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Shr.Open();
                    SqlCommand cmd = new SqlCommand("insert into Showroom(s_roomID,name,owner,manager,cantactno,branch,address) values(@SID,@SN,@SO,@SM,@SC,@SB,@SA)", Shr);
                    cmd.Parameters.AddWithValue("@SID", showIDtxt.Text);
                    cmd.Parameters.AddWithValue("@SN", nametxt.Text);
                    cmd.Parameters.AddWithValue("@SO", ownertxt.Text);
                    cmd.Parameters.AddWithValue("@SM", managertxt.Text);
                    cmd.Parameters.AddWithValue("@SC", contacttxt.Text);
                    cmd.Parameters.AddWithValue("@SB", branchtxt.Text);
                    cmd.Parameters.AddWithValue("@SA", addresstxt.Text);
                    cmd.ExecuteNonQuery();
                    Shr.Close();
                    MessageBox.Show("Row added successfully");
                    displayShow();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showIDtxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ownertxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            managertxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            contacttxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            branchtxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            addresstxt.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            if(showIDtxt.Text=="")
            {
                key = 0;
            }else
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (showIDtxt.Text == "" || nametxt.Text == "" || ownertxt.Text == "" || managertxt.Text == "" || contacttxt.Text == "" || branchtxt.Text == "" || addresstxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Shr.Open();
                    SqlCommand cmd = new SqlCommand("Update Showroom set s_roomID=@SID,name=@SN,owner=@SO,manager=@SM,cantactno=@SC,branch=@SB,address=@SA ", Shr);
                    cmd.Parameters.AddWithValue("@SID", showIDtxt.Text);
                    cmd.Parameters.AddWithValue("@SN", nametxt.Text);
                    cmd.Parameters.AddWithValue("@SO", ownertxt.Text);
                    cmd.Parameters.AddWithValue("@SM", managertxt.Text);
                    cmd.Parameters.AddWithValue("@SC", contacttxt.Text);
                    cmd.Parameters.AddWithValue("@SB", branchtxt.Text);
                    cmd.Parameters.AddWithValue("@SA", addresstxt.Text);
                    cmd.ExecuteNonQuery();
                    Shr.Close();
                    MessageBox.Show("Row updated successfully");
                    displayShow();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void branchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void contacttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ownertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void showIDtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
