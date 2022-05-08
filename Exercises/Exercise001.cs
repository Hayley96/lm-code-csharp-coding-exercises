using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public bool NullOrEmpty(string words) => 
            String.IsNullOrEmpty(words);
        public string ConvertToString(char words) => 
            char.ToString(words);


        public string CapitalizeWord(string word) => 
            !NullOrEmpty(word) ? char.ToUpper(word[0]) + word.Substring(1) : "Invalid input";

        public string GenerateInitials(string firstName, string lastName) => 
            !NullOrEmpty(firstName) && !NullOrEmpty(lastName) ? 
            ConvertToString(firstName[0]) + "." + ConvertToString(lastName[0]) : "Invalid input";

        public double AddVat(double originalPrice, double vatRate) => 
            Math.Round((Double)(vatRate/100) * originalPrice + originalPrice, 2);

        public string Reverse(string sentence) => 
            !NullOrEmpty(sentence) ? new string(sentence.ToCharArray().Reverse().ToArray()) : "Invalid input";

        public int CountLinuxUsers(List<User> users) => 
            users.Count(user => user.Type.Equals("Linux"));
    }
}
