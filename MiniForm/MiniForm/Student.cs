using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_tasks
{
    internal class Student
    {
        private string userName;
        private string passWord;
        private string selectGender;
        private string selectAge;
        private string fileContent;
        private System.Drawing.Image fss;
        private string imagePath;

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public string PassWord
        {
            get
            {
                return passWord;
            }
            set
            {
                passWord = value;
            }
        }
        public string SelectGender
        {
            get
            {
                return selectGender;
            }
            set
            {
                selectGender = value;
            }
        }
        public string SelectAge
        {
            get
            {
                return selectAge;
            }
            set
            {
                selectAge = value;
            }
        }
        public string FileContent
        {
            get
            {
                return fileContent;
            }
            set
            {
                fileContent = value;
            }
        }
        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
            }
        }
    }
}
