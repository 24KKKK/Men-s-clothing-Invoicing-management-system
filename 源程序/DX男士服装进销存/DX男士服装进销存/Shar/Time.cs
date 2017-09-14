using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DX男士服装进销存.Shar
{
     static class Time
    {
        public static String Get_rili()
        {
            int YEAR = DateTime.Now.Year;
            int MONTH = DateTime.Now.Month;
            int DAY = DateTime.Now.Day;
            int HOUR = DateTime.Now.Hour;
            int MIN = DateTime.Now.Minute;
            int SECOND = DateTime.Now.Second;
            String Time = YEAR.ToString();
            if (MONTH < 10)
            {
                Time = Time + "0" + MONTH.ToString();
            }
            else
            {
                Time = Time + MONTH.ToString();
            }
            if (DAY < 10)
            {
                Time = Time + "0" + DAY.ToString();
            }
            else
            {
                Time = Time + DAY.ToString();
            }
            if (HOUR < 10)
            {
                Time = Time + "0" + HOUR.ToString();
            }
            else
            {
                Time = Time + HOUR.ToString();
            }
            if (MIN < 10)
            {
                Time = Time + "0" + MIN.ToString();
            }
            else
            {
                Time = Time + MIN.ToString();
            }
            if (SECOND < 10)
            {
                Time = Time + "0" + SECOND.ToString();
            }
            else
            {
                Time = Time + SECOND.ToString();
            }
            return (Time);

        }
    }
}
