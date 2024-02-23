using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service1
{
    public class Blogpost
    {
        private string postTitle;
        private string postDescriptions;
        private bool postApproved;

        public string PostTitle
        {
            get
            {
                return postTitle;
            }
            set
            {
                postTitle = value;
            }
        }

        public string PostDescription
        {
            get
            {
                return postDescriptions;
            }
            set
            {
                postDescriptions = value;
            }
        }

        public bool PostApproved
        {
            get
            {
                return postApproved;
            }
            set
            {
                postApproved = value;
            }
        }
    }
}