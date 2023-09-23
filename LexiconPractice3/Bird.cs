using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.WingSpan = 315.3;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.Name}: Chirps!");
        }

        public override string Stat()
        {
            return $"{base.Stat()}\nWingSpan: {this.WingSpan}";
        }
    }
}
