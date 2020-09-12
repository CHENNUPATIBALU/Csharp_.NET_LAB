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

        public static void checkUID(String suid)
        {
            IsNotAlphanumericException iae = new IsNotAlphanumericException();
            if (!(suid.Any(char.IsDigit)))
            {
                throw new IsNotAlphanumericException();
            }
        }
        public static void checkEmail(String emailid)
        {
            if (emailid.Contains("@"))
            { }
            else
                throw new AtException();
        }

        public static void checkSem(int sem)
        {
            if(!(sem > 0 && sem <= 8))
            {
                throw new MaxSemException();
            }
            else if(!(sem.ToString().Any(Char.IsDigit)))
                throw new FormatException();
        }
        public void ReadData(int n)
        {
            Console.WriteLine("Enter the details of Student-" + n);
            try
            {
                Console.WriteLine("Enter Student UID: ");
                UID = Console.ReadLine();
                checkUID(UID);
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
                checkEmail(email);
            }
            catch(AtException a)
            {
                Console.WriteLine("@ symbol is missing in Email, Try Again");
                Console.WriteLine("Enter Student Email: ");
                email = Console.ReadLine();
                checkEmail(email);
            }

            try
            { 
                Console.WriteLine("Enter Semester: ");
                semester = Convert.ToInt32(Console.ReadLine());
                checkSem(semester);
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
            Console.WriteLine();
        }
        public void DisplayData(int n)
        {
            Console.WriteLine("Details of Student-" + n);
            Console.WriteLine("UID: " + UID + "\n" + "Student Name: "+studentName+"\n"+"Semester: "+semester+"\n"+"Email: "+email+"\n");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] s = new Student[n];
            for(int i=0;i<n;i++)
            {
                s[i] = new Student();
                s[i].ReadData(i + 1);
            }
                
            for (int i = 0; i < n; i++)
                s[i].DisplayData(i+1);
            Console.ReadLine();
        }
    }
}
