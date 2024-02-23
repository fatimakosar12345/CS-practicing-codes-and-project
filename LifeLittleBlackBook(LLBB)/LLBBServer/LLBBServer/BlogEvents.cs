using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;

namespace LLBBServer
{
    public class BlogEvents
    {
        private string Category;
        private string Day_No;
        private string Month_No;
        private string Year;
        private string time;

        public string EventCategory
        {
            get
            {
                return Category;
            }
            set
            {
                Category = value;
            }
        }

        public string EventDay
        {
            get
            {
                return Day_No;
            }
            set
            {
                Day_No = value;
            }
        }

        public string EventMonth
        {
            get
            {
                return Month_No;
            }
            set
            {
                Month_No = value;
            }
        }
        public string EventYear
        {
            get
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }

        public string EventTime
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
    }
}