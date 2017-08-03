using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExercicio2
{
    class ValorMuitoBaixoException : Exception
    {
        
        public ValorMuitoBaixoException(string message) :base(message) { }
    }
}
