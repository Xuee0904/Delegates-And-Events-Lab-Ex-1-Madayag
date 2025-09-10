using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{
    internal class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Gender = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static string Birthday = " ";
        /*public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;*/

        public static string GetFirstName(string txt)
        {
            StudentInfoClass.FirstName = txt;
            return FirstName;
        }
        public static string GetLastName(string txt)
        {
            StudentInfoClass.LastName = txt;
            return LastName;
        }
        public static string GetMiddleName(string txt)
        {
            StudentInfoClass.MiddleName = txt;
            return MiddleName;
        }
        public static string GetAddress(string txt)
        {
            StudentInfoClass.Address = txt;
            return Address;
        }
        public static string GetProgram(string txt)
        {
            StudentInfoClass.Program = txt;
            return Program;
        }

        public static string GetBirthday(string txt)
        {
            StudentInfoClass.Birthday = txt;
            return Birthday;
        }
        public static string GetGender(string txt)
        {
            StudentInfoClass.Gender = txt;
            return Gender;
        }
       /* public static long GetAge(long number)
        {
            StudentInfoClass.Age = number;
            return Age;
        }
        public static long GetStudentNo(long number)
        {
            StudentInfoClass.StudentNo = number;
            return StudentNo;
        }
        public static long GetContactNo(long number)
        {
            StudentInfoClass.ContactNo = number;
            return ContactNo;
        }*/


    }
}
