using LLBBServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using LLBB.ServiceReference1;

namespace LLBB
{
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
        }

        private void BIDtxt_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        private void Budget_Load(object sender, EventArgs e)
        {

            DD.Open();
            string query = "SELECT SourceOfIncome,NetIncome,BillExp,InternetExp,MedicalExp,EduExp,FoodExp,MisExp,RIncome,Datee FROM Budget where UserID = '" + UserOut.UserID + "'";
            SqlCommand command = new SqlCommand(query, DD);

            // Execute the query and get the results in a SqlDataReader object
            SqlDataReader reader = command.ExecuteReader();
            //if (ContactClass.count > 0)
            {
                // Iterate over the results and read the data
                while (reader.Read())
                {
                    // Retrieve the data from the reader using the column name or index
                   BudgetClass.count++;
                    BudgetClass.SourceOfIncome.Add(reader["SourceOfIncome"].ToString());
                    BudgetClass.NetIncome.Add(reader["NetIncome"].ToString());
                    BudgetClass.BillExp.Add(reader["BillExp"].ToString());
                    BudgetClass.InternetExp.Add(reader["InternetExp"].ToString());
                    BudgetClass.MedicalExp.Add(reader["MedicalExp"].ToString());
                    BudgetClass.EduExp.Add(reader["EduExp"].ToString());
                    BudgetClass.FoodExp.Add(reader["FoodExp"].ToString());
                    BudgetClass.MiscExp.Add(reader["MisExp"].ToString());
                    BudgetClass.RIncome.Add(reader["RIncome"].ToString());
                    BudgetClass.date.Add(reader["Datee"].ToString());
                    
                        
                    //...
                }
            }
            // Close the reader and the connection
            reader.Close();
            if (DD.State == ConnectionState.Closed)
            {
                DD.Open();
            }
            DD.Close();
            if (BudgetClass.count > 0)
            {
               
                srctxt.Text = (string)BudgetClass.SourceOfIncome[display];
                nettxt.Text = (string)BudgetClass.NetIncome[display];
                billtxt.Text = (string)BudgetClass.BillExp[display];
                medtxt.Text = (string)BudgetClass.MedicalExp[display];
                foodtxt.Text = (string)BudgetClass.FoodExp[display];
                Inttxt.Text = (string)BudgetClass.InternetExp[display];
                misctxt.Text = (string)BudgetClass.MiscExp[display];
                remaintxt.Text = (string)BudgetClass.RIncome[display];
                datetxt.Text = (string)BudgetClass.date[display];
                edutxt.Text = (string)BudgetClass.EduExp[display];
            }
            else
            {
                srclabel.Text = "";
                netlabel.Text = "";
                billlabel.Text = "";
                medlabel.Text = "";
                foodlabel.Text = "";
                Intlabel.Text = "";
                misclabel.Text = "";
                Remainlabel.Text = "";
                datelabel.Text = "";
                edulabel.Text = "";

                srctxt.Text = "";
                nettxt.Text = "";
                billtxt.Text = "";
                medtxt.Text = "";
                foodtxt.Text = "";
                Inttxt.Text = "";
                misctxt.Text = "";
                remaintxt.Text = "";
                datetxt.Text = "";
                edutxt.Text = "";
                Textlabel.Text = "No data Record";
            }
        }

        
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (SrcOfIncm.Text == "" || NetIncm.Text == "" || Bill.Text == "" || Medical.Text == "" || Food.Text == "" || Internet.Text==""||Education.Text==""||Misc.Text==""||RemainIncm.Text==""||date.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    {
                        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                        ServiceReference1.BlogBudget addbudget = new ServiceReference1.BlogBudget();

                      
                        addbudget.BudgetSourceOfIncome = SrcOfIncm.Text;
                        addbudget.BudgetNetIncome = NetIncm.Text;
                        addbudget.BudgetBillExp = Bill.Text;
                        addbudget.BudgetInternetExp = Internet.Text;
                        addbudget.BudgetMedicalExp = Medical.Text;
                        addbudget.BudgetEduExp = Education.Text;
                        addbudget.BudgetFoodExp = Food.Text;
                        addbudget.BudgetMisExp = Misc.Text;
                        addbudget.BudgetRIncome = RemainIncm.Text;
                        addbudget.BudgetDate = date.Text;
                        myserver.AddBudget(addbudget, UserOut.UserID);
                        Textlabel.Text = "";

                        srclabel.Text = "Source Of Income";
                        netlabel.Text = "Net Income";
                        billlabel.Text = "Bill Expenses";
                        medlabel.Text = "Medical Expenses";
                        foodlabel.Text = "Food Expenses";
                        Intlabel.Text = "Internet Expenses";
                        misclabel.Text = "Miscellaneous Expenses";
                        Remainlabel.Text = "Remaining Income";
                        datelabel.Text = "Date";
                        edulabel.Text = "Education Expenses";
                        
                        srctxt.Text = SrcOfIncm.Text;
                        nettxt.Text = NetIncm.Text;
                        billtxt.Text = Bill.Text;
                        medtxt.Text = Medical.Text;
                        foodtxt.Text = Food.Text;
                        Inttxt.Text = Internet.Text;
                        misctxt.Text = Misc.Text;
                        remaintxt.Text = RemainIncm.Text;
                        datetxt.Text = date.Text;
                        edutxt.Text = Education.Text;

                        BudgetClass.count++;
                        BudgetClass.SourceOfIncome.Add(SrcOfIncm.Text.ToString());
                        BudgetClass.NetIncome.Add(NetIncm.Text.ToString());
                        BudgetClass.BillExp.Add(Bill.Text.ToString());
                        BudgetClass.MedicalExp.Add(Medical.Text.ToString());
                        BudgetClass.EduExp.Add(Education.Text.ToString());
                        BudgetClass.InternetExp.Add(Internet.Text.ToString());
                        BudgetClass.MiscExp.Add(Misc.Text.ToString());
                        BudgetClass.RIncome.Add(RemainIncm.Text.ToString());
                        BudgetClass.date.Add(date.Text.ToString());
                        BudgetClass.FoodExp.Add(Food.Text.ToString());
                        
                        BudgetClass.SourceOfIncome[BudgetClass.count - 1] = SrcOfIncm.Text;
                        BudgetClass.NetIncome[BudgetClass.count - 1] = NetIncm.Text;
                        BudgetClass.BillExp[BudgetClass.count - 1] = Bill.Text;
                        BudgetClass.MedicalExp[BudgetClass.count - 1] = Medical.Text;
                        BudgetClass.EduExp[BudgetClass.count - 1] = Education.Text;
                        BudgetClass.InternetExp[BudgetClass.count - 1] = Internet.Text;
                        BudgetClass.MiscExp[BudgetClass.count - 1] = Misc.Text;
                        BudgetClass.RIncome[BudgetClass.count - 1] = RemainIncm.Text;
                        BudgetClass.date[BudgetClass.count - 1] = date.Text;
                        BudgetClass.FoodExp[BudgetClass.count - 1] = Food.Text;

                        if (DD.State == ConnectionState.Closed)
                        {
                            DD.Open();
                        }
                        DD.Close();
                       

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int display = 0;
        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (BudgetClass.count <= 0)
            {
                Textlabel.Text = "No more data for deletion";
                srclabel.Text = "";
                netlabel.Text = "";
                billlabel.Text = "";
                medlabel.Text = "";
                foodlabel.Text = "";
                Intlabel.Text = "";
                misclabel.Text = "";
                Remainlabel.Text = "";
                datelabel.Text = "";
                edulabel.Text = "";

                srctxt.Text = "";
                nettxt.Text = "";
                billtxt.Text = "";
                medtxt.Text = "";
                foodtxt.Text = "";
                Inttxt.Text = "";
                misctxt.Text = "";
                remaintxt.Text = "";
                datetxt.Text = "";
                edutxt.Text = "";
            }
            else
            {
                ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                ServiceReference1.BlogBudget delbudget = new ServiceReference1.BlogBudget();

                delbudget.BudgetSourceOfIncome = srctxt.Text;
                delbudget.BudgetNetIncome = nettxt.Text;
                delbudget.BudgetBillExp = billtxt.Text;
                delbudget.BudgetMedicalExp = medtxt.Text;
                delbudget.BudgetFoodExp = foodtxt.Text;
                delbudget.BudgetInternetExp = Inttxt.Text;
                delbudget.BudgetMisExp = misctxt.Text;
                delbudget.BudgetRIncome = remaintxt.Text;
                delbudget.BudgetDate = datetxt.Text;
                delbudget.BudgetEduExp = edutxt.Text;
                myserver.DeleteBudget(UserOut.UserID, delbudget);

                if (display >= 0 && display < BudgetClass.count - 1)
                {
                   
                    srctxt.Text = (string)BudgetClass.SourceOfIncome[display+1];
                    nettxt.Text = (string)BudgetClass.NetIncome[display+1];
                    billtxt.Text =(string)BudgetClass.BillExp[display+1] ;
                    medtxt.Text = (string)BudgetClass.MedicalExp[display+1];
                    foodtxt.Text =(string)BudgetClass.FoodExp[display+1] ;
                    Inttxt.Text = (string)BudgetClass.InternetExp[display+1];
                    misctxt.Text =(string)BudgetClass.MiscExp[display+1] ;
                    remaintxt.Text= (string)BudgetClass.RIncome[display + 1];
                    datetxt.Text =(string)BudgetClass.date[display+1] ;
                    edutxt.Text = (string)BudgetClass.EduExp[display+1];

                }
                else if (display == BudgetClass.count - 1 && BudgetClass.count >= 2)
                {
                    srctxt.Text = (string)BudgetClass.SourceOfIncome[display - 1];
                    nettxt.Text = (string)BudgetClass.NetIncome[display - 1];
                    billtxt.Text = (string)BudgetClass.BillExp[display - 1];
                    medtxt.Text = (string)BudgetClass.MedicalExp[display - 1];
                    foodtxt.Text = (string)BudgetClass.FoodExp[display - 1];
                    Inttxt.Text = (string)BudgetClass.InternetExp[display - 1];
                    misctxt.Text = (string)BudgetClass.MiscExp[display - 1];
                    remaintxt.Text = (string)BudgetClass.RIncome[display - 1];
                    datetxt.Text = (string)BudgetClass.date[display - 1];
                    edutxt.Text = (string)BudgetClass.EduExp[display - 1];
                }
                else if (display == 0 && BudgetClass.count == 1)
                {
                    Textlabel.Text = "No more data for deletion";
                    srclabel.Text = "";
                    netlabel.Text = "";
                    billlabel.Text = "";
                    medlabel.Text = "";
                    foodlabel.Text = "";
                    Intlabel.Text = "";
                    misclabel.Text = "";
                    Remainlabel.Text = "";
                    datelabel.Text = "";
                    edulabel.Text = "";

                    srctxt.Text = "";
                    nettxt.Text = "";
                    billtxt.Text = "";
                    medtxt.Text = "";
                    foodtxt.Text = "";
                    Inttxt.Text = "";
                    misctxt.Text = "";
                    remaintxt.Text = "";
                    datetxt.Text = "";
                    edutxt.Text = "";
                }
                if (display >= 0 && display < BudgetClass.count - 1)
                {
                    for (int j = display; j < BudgetClass.count - 1; j++)
                    {
                        BudgetClass.SourceOfIncome[j] = BudgetClass.SourceOfIncome[j + 1];
                        BudgetClass.NetIncome[j] = BudgetClass.NetIncome[j + 1];
                        BudgetClass.BillExp[j] = BudgetClass.BillExp[j + 1];
                        BudgetClass.MedicalExp[j] = BudgetClass.MedicalExp[j + 1];
                        BudgetClass.FoodExp[j] = BudgetClass.FoodExp[j + 1];

                        BudgetClass.InternetExp[j] = BudgetClass.InternetExp[j + 1];
                        BudgetClass.MiscExp[j] = BudgetClass.MiscExp[j + 1];
                        BudgetClass.RIncome[j] = BudgetClass.RIncome[j + 1];
                        BudgetClass.date[j] = BudgetClass.date[j + 1];
                        BudgetClass.EduExp[j] = BudgetClass.EduExp[j + 1];
                    }
                }

                BudgetClass.count--;

                
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (srctxt.Text == "" || nettxt.Text == "" || billtxt.Text == "" || medtxt.Text == "" || foodtxt.Text == "" || Inttxt.Text == "" || edutxt.Text == "" || misctxt.Text == "" || remaintxt.Text == "" || datetxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    {
                        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                        ServiceReference1.BlogBudget budgetedit = new ServiceReference1.BlogBudget();

                        budgetedit.BudgetSourceOfIncome = BudgetClass.SourceOfIncome[display].ToString();
                        budgetedit.BudgetNetIncome = BudgetClass.NetIncome[display].ToString();
                        budgetedit.BudgetBillExp= BudgetClass.BillExp[display].ToString();
                        budgetedit.BudgetMedicalExp = BudgetClass.MedicalExp[display].ToString();
                        budgetedit.BudgetEduExp = BudgetClass.EduExp[display].ToString();

                        budgetedit.BudgetInternetExp = BudgetClass.InternetExp[display].ToString();
                        budgetedit.BudgetMisExp = BudgetClass.MiscExp[display].ToString();
                        budgetedit.BudgetRIncome = BudgetClass.RIncome[display].ToString();
                        budgetedit.BudgetDate = BudgetClass.date[display].ToString();
                        budgetedit.BudgetFoodExp = BudgetClass.FoodExp[display].ToString();
                        myserver.EditBudget(budgetedit, UserOut.UserID, srctxt.Text, nettxt.Text,billtxt.Text,Inttxt.Text,medtxt.Text,edutxt.Text,foodtxt.Text,misctxt.Text,remaintxt.Text,datetxt.Text);


                        BudgetClass.SourceOfIncome[display] = srctxt.Text;
                        BudgetClass.NetIncome[display] = nettxt.Text;
                        BudgetClass.BillExp[display] = billtxt.Text;
                        BudgetClass.MedicalExp[display] = medtxt.Text;
                        BudgetClass.EduExp[display] = edutxt.Text;
                        BudgetClass.InternetExp[display] = Inttxt.Text;
                        BudgetClass.MiscExp[display] = misctxt.Text;
                        BudgetClass.RIncome[display] = remaintxt.Text;
                        BudgetClass.date[display] = datetxt.Text;
                        BudgetClass.FoodExp[display] = foodtxt.Text;

                        MessageBox.Show("Row updated successfully");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            if (BudgetClass.count > 0)
            {
                display--;
                if (display < 0)
                {
                    display = BudgetClass.count - 1;
                }
                srctxt.Text = (string)BudgetClass.SourceOfIncome[display];
                nettxt.Text = (string)BudgetClass.NetIncome[display];
                billtxt.Text = (string)BudgetClass.BillExp[display];
                medtxt.Text = (string)BudgetClass.MedicalExp[display];
                foodtxt.Text = (string)BudgetClass.FoodExp[display];
                Inttxt.Text = (string)BudgetClass.InternetExp[display];
                misctxt.Text = (string)BudgetClass.MiscExp[display];
                remaintxt.Text = (string)BudgetClass.RIncome[display];
                datetxt.Text = (string)BudgetClass.date[display];
                edutxt.Text = (string)BudgetClass.EduExp[display];
            }
            else
            {
                Textlabel.Text = "No data Record";

                srclabel.Text = "";
                netlabel.Text = "";
                billlabel.Text = "";
                medlabel.Text = "";
                foodlabel.Text = "";
                Intlabel.Text = "";
                misclabel.Text = "";
                Remainlabel.Text = "";
                datelabel.Text = "";
                edulabel.Text = "";

                srctxt.Text = "";
                nettxt.Text = "";
                billtxt.Text = "";
                medtxt.Text = "";
                foodtxt.Text = "";
                Inttxt.Text = "";
                misctxt.Text = "";
                remaintxt.Text = "";
                datetxt.Text = "";
                edutxt.Text = "";
            }
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (BudgetClass.count > 0)
            {
                display++;
                if (display >= BudgetClass.count)
                {
                    display = 0;
                }
                srctxt.Text = (string)BudgetClass.SourceOfIncome[display];
                nettxt.Text = (string)BudgetClass.NetIncome[display];
                billtxt.Text = (string)BudgetClass.BillExp[display];
                medtxt.Text = (string)BudgetClass.MedicalExp[display];
                foodtxt.Text = (string)BudgetClass.FoodExp[display];
                Inttxt.Text = (string)BudgetClass.InternetExp[display];
                misctxt.Text = (string)BudgetClass.MiscExp[display];
                remaintxt.Text = (string)BudgetClass.RIncome[display];
                datetxt.Text = (string)BudgetClass.date[display];
                edutxt.Text = (string)BudgetClass.EduExp[display];
            }
            else
            {
                Textlabel.Text = "No data Record";

                 srclabel.Text = "";
                netlabel.Text = "";
                billlabel.Text = "";
                medlabel.Text = "";
                foodlabel.Text = "";
                Intlabel.Text = "";
                misclabel.Text = "";
                Remainlabel.Text = "";
                datelabel.Text = "";
                edulabel.Text = "";

                srctxt.Text = "";
                nettxt.Text = "";
                billtxt.Text = "";
                medtxt.Text = "";
                foodtxt.Text = "";
                Inttxt.Text = "";
                misctxt.Text = "";
                remaintxt.Text = "";
                datetxt.Text = "";
                edutxt.Text = "";
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
