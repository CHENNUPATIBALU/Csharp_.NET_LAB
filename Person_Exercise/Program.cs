using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Exercise
{
    class Person
    {
        private String firstName;
        private String lastName;
        private String emailID;
        private DateTime dob;


        public Person(String fName, String lName, String email, DateTime d)
        {
            this.dob = d;
            this.emailID = email;
            this.firstName = fName;
            this.lastName = lName;
        }
        public Person(String fName, String lName, String email)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.emailID = email;    
        }
        public Person(String fName, String lName, DateTime d)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.dob = d;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmailID { get => emailID; set => emailID = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public bool Adult
        {
            get
            {
                if ((DateTime.Today.Year - dob.Year) >= 18)
                    return true;
                else
                    return false;
            }
        }
        public String SunSign
        {
            get
            {
                return new SunSign().ZodaicSign(dob.Year,dob.Month,dob.Day);
            }
        }
        public bool Birthday
        {
            get
            {
                if ((DateTime.Now.Month == dob.Month) && (DateTime.Now.Day == dob.Day))
                    return true;
                else
                    return false;
            }
        }
        public String ScreenName
        {
            get
            {
                return lastName + dob.Month.ToString() + SunSign;
            }
        }


}
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Name: ");
            String fname = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            String lname = Console.ReadLine();
            Console.Write("Enter Email: ");
            String email = Console.ReadLine();
            if (email.Contains("@")) { }
            else
            {
                Console.WriteLine("Please Enter Valid Email");
            }
            Console.WriteLine();
            Console.WriteLine("** Date Of Birth **");
            Console.Write("Enter the Birth Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Birth Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Birth Date: ");
            int bdate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            DateTime dob = new DateTime(year,month,bdate);

            Person p1 = new Person(fname,lname,email,dob);
            Console.WriteLine("Person is adult: "+p1.Adult);
            Console.WriteLine("SunSign: "+p1.SunSign);
            Console.WriteLine("Today Birthday: "+p1.Birthday);
            Console.WriteLine("Alloted Screen: "+p1.ScreenName);
            Console.WriteLine();
            Person p2 = new Person(fname, lname, email);
            Console.WriteLine("Person is adult: " + p2.Adult);
            Console.WriteLine("Today Birthday: " + p2.Birthday);
            Console.WriteLine("Alloted Screen: " + p2.ScreenName);
            Console.WriteLine();
            Person p3 = new Person(fname, lname,  dob);
            Console.WriteLine("Person is adult: " + p3.Adult);
            Console.WriteLine("SunSign: " + p3.SunSign);
            Console.WriteLine("Today Birthday: " + p3.Birthday);
            Console.WriteLine("Alloted Screen: " + p3.ScreenName);

            Console.ReadLine();
        }
    }
}
