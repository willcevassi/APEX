using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExercicio2
{
    class ValorMuitoAltoExemption: Exception
    {
        public ValorMuitoAltoExemption(string message) : base(message) { }
    }
}
