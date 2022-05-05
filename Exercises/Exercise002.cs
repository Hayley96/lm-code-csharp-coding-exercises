using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            // check if the Person objects property 'City' has value equal to Manchester, if true return true, else false
            if(person.City == "Manchester") { return true; }
            return false;
           
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            // Replace the exception statement below with your code!
            if (person.Age < ageLimit) { return false; }
            return true;
        }
    }
}
