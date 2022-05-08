using System;
using Exercises.Models;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            try {
                return dateTime.AddSeconds(Constants.GigaSecond);
            } 
            catch (Exception ex) {
               throw new ArgumentOutOfRangeException("Date entered was invalid", ex.Message);
            }
        }
    }
}
