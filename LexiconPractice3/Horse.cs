using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Horse : Animal
    {
        public double Size { get; set; }

        public Horse(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.Size = 219;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.Name}: Neigh! Neigh!");
        }

        public override string Stat()
        {
            return $"{base.Stat()}\nSize: {this.Size}";
        }
    }
}
