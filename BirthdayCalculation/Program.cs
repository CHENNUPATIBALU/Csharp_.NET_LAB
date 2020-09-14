using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCalculation
{
    class Birthday
    {
        public int CheckBirthday(int year, int month, int btdate)
        {
             DateTime bdate = new DateTime(year, month, btdate);
             DateTime tdate = DateTime.Today;
             int res = DateTime.Compare(bdate, tdate);
            if (res > 0)
            {
                if ((tdate.Year - bdate.Year) == 0)
                    return -1;
                else
                    return 1;
            }
            else
            {
                if ((tdate.Year - bdate.Year) >= 135)
                    return 2;
            }
                
            return 0;
        }
        public int TodayBirthday(int year, int month, int btdate)
        {
            DateTime bmonth = new DateTime(year, month, btdate);
            int tmonth = DateTime.Today.Month;
            DateTime bdate = new DateTime(year, month, btdate);
            DateTime tdate = DateTime.Today;
            int res = DateTime.Compare(bdate, tdate);
            if (res < 0 && bmonth.Month == tmonth)
            {
                return 1;
            }
            return 0;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Birthday b = new Birthday();
            SunSign s = new SunSign();
            for (; ;)
            {
                //read Year,Month,Date seperately
                Console.Write("Enter the Birth Year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Birth Month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Birth Date: ");
                int btdate = Convert.ToInt32(Console.ReadLine());

                int result = b.CheckBirthday(year, month, btdate);
                int result1 = b.TodayBirthday(year, month, btdate);

                int age = (DateTime.Now.Year - year);

                if (result1 == 1)
                {
                    Console.WriteLine("** Oola, Today is your BirthDay **");
                }
                if (result == 2)
                {
                    Console.WriteLine("** Your Age is Impossible **");
                }
                if (result == -1)
                    Console.WriteLine("** You are not Yet Born!! **");
                Console.WriteLine("** Your Age is " + age +" **");
                s.ZodaicSign(year, month, btdate);
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
