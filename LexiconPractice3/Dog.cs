using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Dog : Animal
    {

        public string Breed { get; set; }
        public Dog(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.Breed = "Dobermann";
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.Name}: Woof! Woof!");
        }

        public override string Stat()
        {
            return $"{base.Stat()}\nBreed: {this.Breed}";
        }

        public string RandomMethod()
        {
            return "This is a random string for dog.";
        }
    }
}
