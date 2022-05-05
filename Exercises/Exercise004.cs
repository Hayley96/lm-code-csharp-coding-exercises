using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            // Replace the exception statement below with your code!
            if(dateTime == null) { return new DateTime(); }
            double GigaSecond = 1000000000;
            DateTime result = dateTime.AddSeconds(GigaSecond);
            return result;
        }
    }
}
