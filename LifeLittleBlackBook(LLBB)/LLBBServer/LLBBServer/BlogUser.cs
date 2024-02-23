using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace LLBBServer
{
    public class BlogUser
    {
        private string FirstName;
        private string LastName;
        private string UserName;
        private string Address;
        private string DateOfBirth;
        private string Password;
        private string ConfirmPassword;

        public string UserFName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string UserLName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public string UserUName
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
        public string UserAddress
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string UserDOB
        {
            get
            {
                return DateOfBirth;
            }
            set
            {
                DateOfBirth = value;
            }
        }
        public string UserPassword
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public string UserCPassword
        {
            get
            {
                return ConfirmPassword;
            }
            set
            {
                ConfirmPassword = value;
            }
        }
    }
}