using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            // add gigasecond to datetime and return results
            double GigaSecond = 1000000000;
            DateTime result = dateTime.AddSeconds(GigaSecond);
            return result;
        }
    }
}
