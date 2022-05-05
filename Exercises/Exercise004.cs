using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            // add gigasecond to datetime and return results
            DateTime result;
            try {
                DateTime.TryParse(dateTime.ToString(), out result);
                
                double GigaSecond = 1000000000;
                return result = dateTime.AddSeconds(GigaSecond);
                //return result;
               
            } 
            catch (Exception ex) {
               throw new ArgumentOutOfRangeException("Date entered was invalid", ex.Message);
            }
        }
    }
}
