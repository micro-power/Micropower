using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Micropower.Models
{
    public class SetKolumnatorrModel
    {
        public string DateTimeStart { get; set; }

        public string GetSetString(int val)
        {
            int startTimeInSeconds = 0;
            int startModifiedJoulianDay = 0;
            string setString = string.Format("$set^{0}^{1}#",startTimeInSeconds,startModifiedJoulianDay);

            return setString;
        }
        
        public int CountModifiedJoulianDay  (DateTime dateTime)
        {
            DateTime date = dateTime;
            int X = (date.Month+9)/ 12;
            int A = 4716 + date.Year + X;
            int Y = (275 * date.Month / 9);
            int V = (7 * A / 4);
            int B = 1729280 + 367 * date.Year + Y - V + date.Day;
            int Q = (A + 83) / 100;
            int W = (3 * (Q + 1) / 4);
            int JD = B + 38 - W;
            return JD - 2400000;
        }
    }
}