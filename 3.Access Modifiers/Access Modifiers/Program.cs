using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    /*Access Modifier: A way to control access to a class and/or its members
     *  create safety on programs avoiding bugs in the code
     *
     */
    class Program
    {
        static void Main(String[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982,1,1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
