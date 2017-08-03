using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MinhaExcecao: Exception
    {
        public MinhaExcecao() : base() { }
        public MinhaExcecao(string message) : base(message)
        {

        }
    }
}
