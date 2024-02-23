using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LLBBServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection DD = new SqlConnection(@"Data Source=desktop-v788fuv;Initial Catalog=LLBB;Integrated Security=True");

        public void AddContact(BlogContact contact, string UserID)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("insert into ContactBook(UserID,Name,PhoneNo,Address,Day,Datee) values(@UID,@N,@PN,@AD,@D,@DAT)", DD);

            cmd.Parameters.AddWithValue("@UID", UserID);
            cmd.Parameters.AddWithValue("@N", contact.ContactName);
            cmd.Parameters.AddWithValue("@PN", contact.ContactPhone);
            cmd.Parameters.AddWithValue("@AD", contact.ContactAddress);
            cmd.Parameters.AddWithValue("@D", contact.ContactDay);
            cmd.Parameters.AddWithValue("@DAT", contact.ContactDate);
            cmd.ExecuteNonQuery();
            DD.Close();

        }

        public void AddEvent(BlogEvents Event, string UserID)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("insert into Events(UserID,Categori,Day_No,Month_No,Year,time) values(@UID,@C,@DN,@MN,@Y,@TIM)", DD);

            cmd.Parameters.AddWithValue("@UID", UserID);
            cmd.Parameters.AddWithValue("@C", Event.EventCategory);
            cmd.Parameters.AddWithValue("@DN", Event.EventDay);
            cmd.Parameters.AddWithValue("@MN", Event.EventMonth);
            cmd.Parameters.AddWithValue("@Y", Event.EventYear);
            cmd.Parameters.AddWithValue("@TIM", Event.EventTime);
            cmd.ExecuteNonQuery();
        }

        public void AddNotes(BlogNotes Note, string UserID)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("insert into Diary(UserID,Datee,Day,Notes) values(@UID,@DAT,@D,@N)", DD);

            cmd.Parameters.AddWithValue("@UID", UserID);
            cmd.Parameters.AddWithValue("@DAT", Note.NotesDate);
            cmd.Parameters.AddWithValue("@D", Note.NotesDay);
            cmd.Parameters.AddWithValue("@N", Note.Notesnotes);

            cmd.ExecuteNonQuery();
        }

        public void AddUser(BlogUser User)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("insert into UserData(FirstName,LastName,UserName,Address,DOB,Password,ConfirmPass) values(@FN,@LN,@UN,@ADD,@DOB,@P,@CP)", DD);
            cmd.Parameters.AddWithValue("@FN", User.UserFName);
            cmd.Parameters.AddWithValue("@LN", User.UserLName);
            cmd.Parameters.AddWithValue("@UN", User.UserUName);
            cmd.Parameters.AddWithValue("@ADD", User.UserAddress);
            cmd.Parameters.AddWithValue("@DOB", User.UserDOB);
            cmd.Parameters.AddWithValue("@P", User.UserPassword);
            cmd.Parameters.AddWithValue("@CP", User.UserCPassword);
            cmd.ExecuteNonQuery();
            DD.Close();
        }

        public void DeleteContact(string id, BlogContact contact)
        {
            DD.Open();
            SqlCommand cmd1 = DD.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            cmd1.CommandText = "delete from ContactBook where UserID = '" + id + "' and Name='" + contact.ContactName + "' and PhoneNo='" + contact.ContactPhone + "' and Address = '" + contact.ContactAddress + "' and Day='" + contact.ContactDay + "' and Datee='" + contact.ContactDate + "'";

            cmd1.ExecuteNonQuery();
            DD.Close();
        }

        public void DeleteBudget(string id, BlogBudget budget)
        {
            DD.Open();
            SqlCommand cmd1 = DD.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            cmd1.CommandText = "delete from Budget where UserID = '" + id + "' and SourceOfIncome='" + budget.BudgetSourceOfIncome + "' and NetIncome='" + budget.BudgetNetIncome + "' and BillExp = '" + budget.BudgetBillExp + "' and InternetExp='" + budget.BudgetInternetExp + "' and MedicalExp='" + budget.BudgetMedicalExp + "' and EduExp='" + budget.BudgetEduExp + "' and FoodExp='" + budget.BudgetFoodExp + "' and MisExp = '" + budget.BudgetMisExp + "' and RIncome='" + budget.BudgetRIncome + "' and Datee='" + budget.BudgetDate + "'";

            cmd1.ExecuteNonQuery();
            DD.Close();
        }

        public void DeleteEvent(string id, BlogEvents events)
        {
            DD.Open();
            SqlCommand cmd1 = DD.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            cmd1.CommandText = "delete from Events where UserID = '" + id + "' and Categori='" + events.EventCategory + "' and Day_No='" + events.EventDay + "' and Month_No = '" + events.EventMonth + "' and Year='" + events.EventYear + "' and time='" + events.EventTime + "'";

            cmd1.ExecuteNonQuery();
            DD.Close();
        }
      
        public void DeleteNotes(string id, BlogNotes notes)
        {
            DD.Open();
            SqlCommand cmd1 = DD.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            cmd1.CommandText = "delete from Diary where UserID = '" + id + "' and Datee='" + notes.NotesDate + "' and Day='" + notes.NotesDay + "' and Notes = '" + notes.Notesnotes + "'";
            cmd1.ExecuteNonQuery();
            DD.Close();
        }
        public void DeleteUser(BlogUser user)
        {
            DD.Open();
            SqlCommand cmd = DD.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from UserData where UserName='" + user.UserUName + "' and password='" + user.UserPassword + "'";
            cmd.ExecuteNonQuery();
            DD.Close();
        }

        public void EditBudget(BlogBudget budget, string id, string SOI, string NI, string Bill, string Internet, string Medical, string Education, string Food, string Misc, string RIncome, string Date)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("update Budget set UserID=@UID,SourceOfIncome=@SOI,NetIncome=@NI,BillExp=@BE,InternetExp=@IE,MedicalExp=@MDE,EduExp=@EE,FoodExp=@FE,MisExp=@ME,RIncome=@RI,Datee=@DAT where UserID='" + id + "' and SourceOfIncome='" + budget.BudgetSourceOfIncome + "' and NetIncome='" + budget.BudgetNetIncome + "' and BillExp='" + budget.BudgetBillExp + "' and MedicalExp='" + budget.BudgetMedicalExp + "' and EduExp='" + budget.BudgetEduExp + "' and InternetExp='" + budget.BudgetInternetExp + "' and MisExp='" + budget.BudgetMisExp + "' and RIncome='" + budget.BudgetRIncome + "' and Datee='" + budget.BudgetDate + "' and FoodExp='" + budget.BudgetFoodExp + "'", DD);
            cmd.Parameters.AddWithValue("@UID", id);
            cmd.Parameters.AddWithValue("@SOI", SOI);
            cmd.Parameters.AddWithValue("@NI", NI);
            cmd.Parameters.AddWithValue("@BE", Bill);
            cmd.Parameters.AddWithValue("@IE", Internet);
            cmd.Parameters.AddWithValue("@MDE", Medical);
            cmd.Parameters.AddWithValue("@EE", Education);
            cmd.Parameters.AddWithValue("@FE", Food);
            cmd.Parameters.AddWithValue("@ME", Medical);
            cmd.Parameters.AddWithValue("@RI", RIncome);
            cmd.Parameters.AddWithValue("@DAT", Date);

            cmd.ExecuteNonQuery();
            DD.Close();
        }

        public void EditContact(BlogContact contact,string id, string name, string phone, string day, string date, string address)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("update ContactBook set UserID=@UID,Name=@N,PhoneNo=@PN,Address=@AD,Day=@D,Datee=@DAT where UserID='" + id + "' and Name='" + contact.ContactName + "' and PhoneNo='" + contact.ContactPhone + "' and Address='" + contact.ContactAddress + "' and Day='" + contact.ContactDay + "' and Datee='" + contact.ContactDate + "'", DD);
            cmd.Parameters.AddWithValue("@UID", id);
            cmd.Parameters.AddWithValue("@N", name);
            cmd.Parameters.AddWithValue("@PN", phone);
            cmd.Parameters.AddWithValue("@AD", address);
            cmd.Parameters.AddWithValue("@D", day);
            cmd.Parameters.AddWithValue("@DAT", date);

            cmd.ExecuteNonQuery();
            DD.Close();
        }

        public void EditEvent(BlogEvents Event, string id, string Category, string DayNo, string MonNo, string Year, string time)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("update Events set UserID=@UID,Categori=@C,Day_No=@DN,Month_No=@MN,Year=@Y,time=@TIM where UserID='" + id + "' or Day_No='" + Event.EventDay + "' or Month_No='" + Event.EventMonth + "' or Year='" + Event.EventYear + "' or time='" + Event.EventTime + "'", DD);

            cmd.Parameters.AddWithValue("@UID", id);
            cmd.Parameters.AddWithValue("@C", Category);
            cmd.Parameters.AddWithValue("@DN", DayNo);
            cmd.Parameters.AddWithValue("@MN", MonNo);
            cmd.Parameters.AddWithValue("@Y", Year);
            cmd.Parameters.AddWithValue("@TIM", time);

            cmd.ExecuteNonQuery();
            DD.Close();
        }

        public void EditNotes(BlogNotes Note, string id, string date, string Day, string Notes)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("update Diary set UserID=@UID,Datee=@Dat,Day=@D,Notes=@N where UserID='" + id + "' and Datee='" + Note.NotesDate + "' and Day='" + Note.NotesDay + "' and Notes='" + Note.Notesnotes + "'", DD);
            cmd.Parameters.AddWithValue("@UID", id);
            cmd.Parameters.AddWithValue("@Dat", date);
            cmd.Parameters.AddWithValue("@D", Day);
            cmd.Parameters.AddWithValue("@N", Notes);

            cmd.ExecuteNonQuery();
            DD.Close();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public BlogContact getContact(int contactID)
        {
            return ContactClass.DataStore[contactID];
        }

        public List<BlogContact> getContactlist()
        {
            return ContactClass.DataStore;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        
        public void AddBudget(BlogBudget budget, string userID)
        {
            DD.Open();
            SqlCommand cmd = new SqlCommand("insert into Budget(UserID,SourceOfIncome,NetIncome,BillExp,InternetExp,MedicalExp,EduExp,FoodExp,MisExp,RIncome,Datee) values(@UID,@SOI,@NI,@BE,@IE,@MDE,@EE,@FE,@ME,@RI,@DAT)", DD);

            cmd.Parameters.AddWithValue("@UID", userID);
            cmd.Parameters.AddWithValue("@SOI", budget.BudgetSourceOfIncome);
            cmd.Parameters.AddWithValue("@NI", budget.BudgetNetIncome);
            cmd.Parameters.AddWithValue("@BE", budget.BudgetBillExp);
            cmd.Parameters.AddWithValue("@IE", budget.BudgetInternetExp);
            cmd.Parameters.AddWithValue("@MDE", budget.BudgetMedicalExp);
            cmd.Parameters.AddWithValue("@EE", budget.BudgetEduExp);
            cmd.Parameters.AddWithValue("@FE", budget.BudgetFoodExp);
            cmd.Parameters.AddWithValue("@ME", budget.BudgetMisExp);
            cmd.Parameters.AddWithValue("@RI", budget.BudgetRIncome);
            cmd.Parameters.AddWithValue("@DAT", budget.BudgetDate);

            cmd.ExecuteNonQuery();

            
        }

    }
}
