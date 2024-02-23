using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LLBBServer
{
    public class BlogBudget
    {
 
        private string SourceOfIncome;
        private string NetIncome;
        private string BillExp;
        private string InternetExp;
        private string MedicalExp;
        private string EduExp;
        private string FoodExp;
        private string MisExp;
        private string RIncome;
        private string Date;
        public string BudgetSourceOfIncome
        {
            get
            {
                return SourceOfIncome ;
            }
            set
            {
                SourceOfIncome = value;
            }
        }
        public string BudgetNetIncome
        {
            get
            {
                return NetIncome; 
            }
            set
            {
                NetIncome = value;
            }
        }
        public string BudgetBillExp
        {
            get
            {
                return BillExp;
            }
            set
            {
                BillExp = value;
            }
        }
        public string BudgetInternetExp
        {
            get
            {
                return InternetExp;
            }
            set
            {
                InternetExp = value;
            }
        }
        public string BudgetMedicalExp
        {
            get
            {
                return MedicalExp;
            }
            set
            {
                MedicalExp = value;
            }
        }
        public string BudgetEduExp
        {
            get
            {
                return EduExp;
            }
            set
            {
                EduExp = value;
            }
        }
        public string BudgetFoodExp
        {
            get
            {
                return FoodExp;
            }
            set
            {
                FoodExp = value;
            }
        }
        public string BudgetMisExp
        {
            get
            {
                return MisExp;
            }
            set
            {
                MisExp = value;
            }
        }
        public string BudgetRIncome
        {
            get
            {
                return RIncome;
            }
            set
            {
                RIncome = value;
            }
        }
        public string BudgetDate
        {
            get
            {
                return Date;
            }
            set
            {
                Date = value;
            }
        }
    }
}