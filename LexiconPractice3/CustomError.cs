using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class CustomError : UserError
    {
        private string _message;
        public CustomError(string errorMessage)
        {

            this._message = errorMessage;
        }
        public override string UEMessage()
        {
            return this._message;
        }
    }
}
