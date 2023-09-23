using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age) : base(name, weight, age)
        {

        }
        public string Talk()
        {
            return $"{this.Name} can talk...";
        }

        public override string Stat()
        {
            return $"{base.Stat()}\n{this.Talk()}";
        }
    }
}
