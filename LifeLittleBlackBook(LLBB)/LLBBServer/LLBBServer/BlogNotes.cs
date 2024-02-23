using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;

namespace LLBBServer
{
    public class BlogNotes
    {
        private string date;
        private string day;
        private string notes;

        public string NotesDate
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

        public string NotesDay
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

        public string Notesnotes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }
    }
}