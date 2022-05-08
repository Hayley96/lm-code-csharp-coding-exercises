using System;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input) => 
            !String.IsNullOrEmpty(input) ? 
            input.ToLower().Where(letter => Char.IsLetter(letter)).GroupBy(letter => letter).Count().Equals(Constants.EngAlphabetSize) : false;
    }
}
