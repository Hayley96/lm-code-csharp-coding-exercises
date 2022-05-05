using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            
            if(input == "") { return false; }   // If 'input' string is empty return false
            else 
            {   
                //convert 'input' string to lowercase; create array to act as a frequency holder for alphabet letters;
                //create holder for index (current input char ascii code subtracted by ascii code for 'a'
                string inputToLower = input.ToLower();
                int[] alphabetFreqArr = new int[26];
                int alphabetFreqArrIndex = 0;


                for(int i = 0; i < inputToLower.Length; i++)
                {
                    if (Char.IsLetter(inputToLower[i]))  // check if current char is a letter
                    {
                        alphabetFreqArrIndex = inputToLower[i] - 'a';  //calculate ascii code of current char
                        alphabetFreqArr[alphabetFreqArrIndex] = 1;  //using the new ascii code, update our alpha freq arr at index[ascii code] = 1
                    }
                }

                if(Array.Exists(alphabetFreqArr, arrValue => arrValue == 0)) { return false; }  // if our resulting alpha freq arr contains any 0's, return false; return true
                else { return true; }
            }
        }
    }
}
