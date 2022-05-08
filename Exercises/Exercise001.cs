using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public bool CheckNullOrEmpty(string words) => String.IsNullOrEmpty(words);
        public string ConvertToString(char words) => char.ToString(words);


        public string CapitalizeWord(string word) => 
            CheckNullOrEmpty(word) ? "Invalid input" : char.ToUpper(word[0]) + word.Substring(1);

        public string GenerateInitials(string firstName, string lastName) => 
            CheckNullOrEmpty(firstName) || CheckNullOrEmpty(lastName) ? "Invalid input" : ConvertToString(firstName[0]) + "." + ConvertToString(lastName[0]);

        public double AddVat(double originalPrice, double vatRate) => 
            Math.Round((Double)(vatRate/100) * originalPrice + originalPrice, 2);

        public string Reverse(string sentence) => 
            CheckNullOrEmpty(sentence) ? "Invalid input" : new string(sentence.ToCharArray().Reverse().ToArray());

        public int CountLinuxUsers(List<User> users) => 
            users.Count(user => user.Type.Equals("Linux"));
    }
}
