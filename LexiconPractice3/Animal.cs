using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    abstract class Animal
    {
        public Animal()
        {

        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();

        public virtual string Stat()
        {
            return $"Name: {this.Name}\nWeight: {this.Weight}\nAge:{this.Age}";
        }
    }
}
