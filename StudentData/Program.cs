using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentData
{
    class IsNotAlphanumericException : Exception
    {}
    class AtException : Exception
    {}
    class MaxSemException : Exception
    {}
    class Student
    {
        String UID, studentName, email;
        int semester;
        bool isAlphaNumeric(char ch)
        {
            if (ch >= 0 && ch <= 9 && ch >=65 && ch<=90)
                return true;
            return false;
        }
        public void ReadData()
        {
            IsNotAlphanumericException iae = new IsNotAlphanumericException();
            AtException ae = new AtException();
            MaxSemException mse = new MaxSemException();

            try
            {
                Console.WriteLine("Enter Student UID: ");
                UID = Console.ReadLine();
                if (!(UID.Any(char.IsDigit)))
                {
                    throw iae;
                }       
            }
            catch(IsNotAlphanumericException inae)
            {
                Console.WriteLine("UID is not AlphaNumeric, Try Again");
                Console.WriteLine("Enter Student UID: ");
                UID = Console.ReadLine();
            }
            
            Console.WriteLine("Enter Student Name: ");
            studentName = Console.ReadLine();
            try
            {
                Console.WriteLine("Enter Student Email: ");
                email = Console.ReadLine();
                if(email.Contains("@"))
                {}
                else
                    throw ae;
            }
            catch(AtException a)
            {
                Console.WriteLine("@ symbol is missing in Email, Try Again");
                Console.WriteLine("Enter Student Email: ");
                email = Console.ReadLine();
            }

            try
            { 
                Console.WriteLine("Enter Semester: ");
                semester = Convert.ToInt32(Console.ReadLine());
                if (!(semester > 0 && semester <= 8))
                {
                    throw mse;
                }
                else if (!(semester.ToString().Any(Char.IsDigit)))
                    throw new FormatException();

            }
            catch(MaxSemException me)
            {
                Console.WriteLine("Please input the semester correctly (1-8), Try Again");
                Console.WriteLine("Enter Semester: ");
                semester = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message+ ", Try Again");
                Console.WriteLine("Enter Semester: ");
                semester = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("UID: " + UID + "\n" + "Student Name: "+studentName+"\n"+"Semester: "+semester+"\n"+"Email: "+email+"\n");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.ReadData();
            s.DisplayData();
            Console.ReadLine();
        }
    }
}
