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

        public Person()
        { }
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
                return new SunSign().ZodaicSign(dob.Year, dob.Month, dob.Day);
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

    interface IPayable
    {
        double RetrieveDueAmount();
        void AddToDueAmount(int dueAmount);
        void PaymentAddress(String address);
    }

        class Employee : Person, IPayable
        {
            private double salary;
            private String mailing_address;
            private double dueAmount;

            public Employee()
            {
                dueAmount = 0.0;
            }

            public Employee(String fName, String lName, String email,double salary,double dueAmount,String mAddress)
            {
                base.FirstName = fName;
                base.LastName = lName;
                base.EmailID = email;
                this.salary = salary;
                this.dueAmount = dueAmount;
                this.mailing_address = mAddress;
            }

            public double Salary { get { return (salary - dueAmount); } set => salary = value; }
            public string Mailing_address { get => mailing_address; set => mailing_address = value; }

            public void AddToDueAmount(int dueAmount)
            {
                this.dueAmount += dueAmount;
            }

            public void PaymentAddress(string address)
            {
                this.mailing_address = address;
            }

            public double RetrieveDueAmount()
            {
                return dueAmount;
            }
        }

    public class Program
    {
        static void Main(string[] args)
        {

           // Console.WriteLine("** PERSON **");
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
            /*Console.WriteLine("** Date Of Birth **");
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
            Console.WriteLine("Alloted Screen: " + p3.ScreenName);*/

            Console.WriteLine("** EMPLOYEE **");
            
            Console.WriteLine();

            Console.Write("Enter the Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Mailing Address: ");
            String mailingaddress = Console.ReadLine();
            int due = 2000;
            Employee e = new Employee(fname,lname,email,salary,due,mailingaddress);
            
            e.AddToDueAmount(due);
            double x = e.RetrieveDueAmount();
            Console.WriteLine(x);
            Console.WriteLine("Salary: "+e.Salary);
            Console.ReadLine();
        }
    }
}
