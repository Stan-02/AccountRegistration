using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Lab1
{
    public delegate long DelegateNumber(long num);
    public delegate String DelegateText(string text);

    class StudentInfoClass
    {
        public static long StudentNo = 0;
        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Program = "";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static string Address = "";

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }
        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static string GetAddress(string Address)
        {
            return Address;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContact(long Contact)
        {
            return Contact;
        }
    }
}
