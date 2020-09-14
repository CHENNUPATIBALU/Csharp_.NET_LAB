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
                if ((tdate.Year - bdate.Year) >= 135)
                    return 2;
                else if ((tdate.Year - bdate.Year) == 0)
                    return -1;
             }
            return 1;
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
        public void SunSign(int year, int month, int btdate)
        {
            if (month == 1 && btdate >= 20 || month == 2 && btdate <= 19)
            {
                Console.WriteLine("** Zodaic Sign: Aquarius **");
            }
            else if(month == 2 && btdate >= 20 || month == 3 && btdate <= 20)
            {
                Console.WriteLine("** Zodaic Sign: Pisces **");
            }
            else if(month == 3 && btdate >= 21 || month == 4 && btdate <= 20)
            {
                Console.WriteLine("** Zodaic Sign: Aries **");
            }
            else if(month == 4 && btdate >= 21 || month == 5 && btdate <= 20)
            {
                Console.WriteLine("** Zodaic Sign: Taurus **");
            }
            else if (month == 5 && btdate >= 21 || month == 6 && btdate <= 20)
            {
                Console.WriteLine("** Zodaic Sign: Gemini **");
            }
            else if (month == 6 && btdate >= 21 || month == 7 && btdate <= 22)
            {
                Console.WriteLine("** Zodaic Sign: Cancer **");
            }
            else if (month == 7 && btdate >= 23 || month == 8 && btdate <= 22)
            {
                Console.WriteLine("** Zodaic Sign: Leo **");
            }
            else if (month == 8 && btdate >= 23 || month == 9 && btdate <= 22)
            {
                Console.WriteLine("** Zodaic Sign: Virgo **");
            }
            else if (month == 9 && btdate >= 23 || month == 10 && btdate <= 22)
            {
                Console.WriteLine("** Zodaic Sign: Libra **");
            }
            else if (month == 10 && btdate >= 23 || month == 11 && btdate <= 22)
            {
                Console.WriteLine("** Zodaic Sign: Scorpio **");
            }
            else if (month == 11 && btdate >= 23 || month == 12 && btdate <= 21)
            {
                Console.WriteLine("** Zodaic Sign: Sagittarius **");
            }
            else if (month == 12 && btdate >= 22 || month == 1 && btdate <= 19)
            {
                Console.WriteLine("** Zodaic Sign: Capricorn **");
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Birthday b = new Birthday();

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
                else if (result == 2)
                {
                    Console.WriteLine("** Your Age is Impossible **");
                }
                else if (result == -1)
                    Console.WriteLine("** You are not Yet Born!! **");
                Console.WriteLine("** Your Age is " + age +" **");
                b.SunSign(year, month, btdate);
            }
            
            Console.ReadLine();
        }
    }
}
