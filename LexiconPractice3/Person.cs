using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LexiconPractice3
{
    public class Person
    {

        //public Person() { }
        //public Person(int age, string firstName, string lastName, double height, double weight) { }

        //Skapa privata properties.
        private int _age;
        private string _fName;
        private string _lName;
        private double _height;
        private double _weigth;

        ////Skapa publika properties med get och set som hämtar eller sätter tilldelad variabel.
        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age kan bara tilldelas ett värde större än 0.");
                }
                _age = value;
            }
        }
        public required string FName
        {
            get { return _fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Förnamn är obligatorisk och får inte vara mindre än 2 tecken eller längre än 10 tecken.");
                }
                _fName = value;
            }

        }
        public required string LName
        {
            get { return _lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Efternamn är obligatorisk och får inte vara mindre än 3 tecken eller större än 15 tecken.");
                }
                _lName = value;
            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
