using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LexiconPractice3
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
            return person;
        }

        //void DisplayEmployeeDetails()
        //{
        //    Console.WriteLine($"\nFirst name: \t{FName}\nLast name: \t{LName}\nage: \t\t{age}\nheight: \t{height}\nweight: \t{weight}");
        //}


    }
}
