using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    public class DateModifier
    {
        public int DaysDiff { get; set; }
        public static int CalculateDaysDiff (string firstData , string secondData)
        {
            DateTime first = DateTime.Parse(firstData);
            DateTime second = DateTime.Parse(secondData);
            int daysDiff = (first - second).Days;
            return daysDiff;
            
        }
    }
}
