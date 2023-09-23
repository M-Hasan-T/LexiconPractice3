using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Worm : Animal
    {

        public bool IsPoisonous { get; set; }

        public Worm(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.IsPoisonous = true;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.Name}: Gurgling!");
        }
        public override string Stat()
        {
            return $"{base.Stat()}\nIs Poisonous: {this.IsPoisonous}";
        }

    }
}
