using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.NrOfSpikes = 7000;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.Name}: Grunting and snuffling, like a pig!");
        }

        public override string Stat()
        {
            return $"{base.Stat()}\nNumber of Spikes: {this.NrOfSpikes}";
        }
    }
}
