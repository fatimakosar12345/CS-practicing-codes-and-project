using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LLBBServer
{
    public class BlogContact
    {       
        private string name;
        private string phone;
        private string day;
        private string date;
        private string address;        

        public string ContactName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string ContactPhone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string ContactDay
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        public string ContactAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string ContactDate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

    }
}
