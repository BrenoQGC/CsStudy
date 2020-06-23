using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public String UserName { get; set; }        
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        //public DateTime Birthdate { get; set; }

        //If theres a requirement for the application that age can be setted only once:

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}