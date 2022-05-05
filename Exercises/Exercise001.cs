using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            //use the index [0] to get first character and capitilize (ToUpper(string[0])), concat with the remaining characters in string starting at character 2 (Substring(1))
            string capitalfirstchar = char.ToUpper(word[0]) + word.Substring(1);
            return capitalfirstchar;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // use index [0] to return the first character from each input string, concat with string "."
            string initials = char.ToString(firstName[0]) + "." + char.ToString(lastName[0]);
            return initials;

        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // calculate vat (get decimal equivalent of %, multiply by amount to get vat amount, add vat amount to the total)
            // round the return value to 2 decimal places
            double totalincvat = (vatRate/100) * originalPrice + originalPrice;
            return Math.Round((Double)totalincvat, 2);
        }

        public string Reverse(string sentence)
        {
            // create array of characters from input string (need array to implement the array reverse method), reverse array, return reversed array as new string
            char[] sentenceArr = sentence.ToCharArray();
            Array.Reverse(sentenceArr);
            return new string(sentenceArr);
        }

        public int CountLinuxUsers(List<User> users)
        {
            // count<predicate> and return the number of users in the list whose property 'Type' equals "Linux"
            int linuxusercount = users.Count(user => user.Type == "Linux");
            return linuxusercount;
        }
    }
}
