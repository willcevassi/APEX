using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o primeiro número");
                int primeiro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int segundo = Convert.ToInt32(Console.ReadLine());
                double resposta = divisor(primeiro, segundo);
                Console.WriteLine("Resultado: " + resposta.ToString("N2"));
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new MinhaExcecao("Você tentou dividir por 0");
            }
        }

        private static double divisor(int primeiro, int segundo)
        {
            double resp = primeiro / segundo;
            return resp;
        }
    }
}
