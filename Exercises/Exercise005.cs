using System;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            
            bool result;
            if(input == "") { return false; }   // If 'input' string is empty return false
            else 
            {   
                //convert 'input' string to lowercase; filter where value is a letter, group by value, count the groups, if count == 26: true; else false;
                return result = input.ToLower().Where(inputVal => Char.IsLetter(inputVal)).GroupBy(inputVal => inputVal).Count() == 26;
            }
        }
    }
}
