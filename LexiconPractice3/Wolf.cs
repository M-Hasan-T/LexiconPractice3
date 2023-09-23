using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Wolf : Animal
    {
        public bool CooperativeHunting { get; set; }

        public Wolf(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.CooperativeHunting = true;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.Name}: Owooooo!");
        }
        public override string Stat()
        {
            return $"{base.Stat()}\nCooperative Hunting: {this.CooperativeHunting}";
        }
    }
}
