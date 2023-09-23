using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Flamingo : Bird
    {
        public bool IsPink { get; set; }

        public Flamingo(string name, double weight, int age) : base(name, weight, age)
        {
            this.IsPink = true;
        }

        public override void DoSound()
        {
            base.DoSound();
        }
        public override string Stat()
        {
            return $"{base.Stat()}\nIs Pink: {this.IsPink}";
        }
    }
}
