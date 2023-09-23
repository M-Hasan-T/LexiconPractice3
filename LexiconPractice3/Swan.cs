using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Swan : Bird
    {
        public bool IsBlack { get; set; }

        public Swan(string name, double weight, int age) : base(name, weight, age)
        {
            this.IsBlack = true;
        }

        public override void DoSound()
        {
            base.DoSound();
        }
        public override string Stat()
        {
            return $"{base.Stat()}\nIs Black: {this.IsBlack}";
        }
    }
}
