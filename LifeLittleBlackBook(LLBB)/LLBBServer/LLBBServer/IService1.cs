using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LLBBServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<BlogContact> getContactlist();

        [OperationContract]
        void AddContact(BlogContact contact,string UserID);
        [OperationContract]
        void AddBudget(BlogBudget budget,string UserID);
        [OperationContract]
        void AddEvent(BlogEvents Event, string UserID);
        [OperationContract]
        void AddNotes(BlogNotes note, string UserID);
        [OperationContract]
        void AddUser(BlogUser user);

        // TODO: Add your service operations here
        [OperationContract]
        void DeleteContact(string id, BlogContact contact);

        [OperationContract]
        void DeleteBudget(string id, BlogBudget budget);

        [OperationContract]
        void DeleteEvent(string id, BlogEvents events);

        [OperationContract]
        void DeleteNotes(string id, BlogNotes notes);

        [OperationContract]
        void DeleteUser(BlogUser user);

        [OperationContract]
        void EditContact(BlogContact contact,string id,string name,string phone,string day,string date,string address);

        [OperationContract]
        void EditBudget(BlogBudget budget, string id, string SOI, string NI, string Bill, string Internet, string Medical, string Education, string Food, string Misc, string RIncome, string Date);

        [OperationContract]
        void EditEvent(BlogEvents Event, string id, string Category, string DayNo, string MonNo, string Year, string time);

        [OperationContract]
        void EditNotes(BlogNotes Note, string id, string date, string Day, string Notes);

    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

