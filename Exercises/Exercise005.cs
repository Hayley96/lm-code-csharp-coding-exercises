using System;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            return String.IsNullOrEmpty(input) ? false : input.ToLower().Where(letter => Char.IsLetter(letter)).GroupBy(letter => letter).Count().Equals(Constants.EngAlphabetSize);
        }
    }
}
