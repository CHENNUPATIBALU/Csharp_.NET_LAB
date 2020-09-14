using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCalculation
{
    class SunSign
    {
        public void ZodaicSign(int year, int month, int btdate)
        {
            if (month == 1 && btdate >= 20 || month == 2 && btdate <= 19)
            {
                Console.WriteLine("** Zodaic Sign: Aquarius **");
            }
            else if (month == 2 && btdate >= 20 || month == 3 && btdate <= 20)
            {
                Console.WriteLine("** Zodaic Sign: Pisces **");
            }
            else if (month == 3 && btdate >= 21 || month == 4 && btdate <= 20)
            {
                Console.WriteLine("** Zodaic Sign: Aries **");
            }
            else if (month == 4 && btdate >= 21 || month == 5 && btdate <= 20)
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
}
