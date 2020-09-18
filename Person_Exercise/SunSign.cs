using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Exercise
{
    class SunSign
    {
        public String ZodaicSign(int year, int month, int btdate)
        {
            if (month == 1 && btdate >= 20 || month == 2 && btdate <= 19)
            {
                return "Aquarius";
            }
            else if (month == 2 && btdate >= 20 || month == 3 && btdate <= 20)
            {
                return "Pisces";
            }
            else if (month == 3 && btdate >= 21 || month == 4 && btdate <= 20)
            {
                return "Aries";
            }
            else if (month == 4 && btdate >= 21 || month == 5 && btdate <= 20)
            {
                return "Taurus";
            }
            else if (month == 5 && btdate >= 21 || month == 6 && btdate <= 20)
            {
                return "Gemini";
            }
            else if (month == 6 && btdate >= 21 || month == 7 && btdate <= 22)
            {
                return "Cancer";
            }
            else if (month == 7 && btdate >= 23 || month == 8 && btdate <= 22)
            {
                return "Leo";
            }
            else if (month == 8 && btdate >= 23 || month == 9 && btdate <= 22)
            {
                return "Virgo";
            }
            else if (month == 9 && btdate >= 23 || month == 10 && btdate <= 22)
            {
                return "Libra";
            }
            else if (month == 10 && btdate >= 23 || month == 11 && btdate <= 22)
            {
                return "Scorpio";
            }
            else if (month == 11 && btdate >= 23 || month == 12 && btdate <= 21)
            {
                return "Sagittarius";
            }
            else if (month == 12 && btdate >= 22 || month == 1 && btdate <= 19)
            {
                return "Capricorn";
            }
            else
                return "Invald date of birth";
        }
    }
}
