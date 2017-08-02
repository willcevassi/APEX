using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o peso:");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura:");
            double a = Convert.ToDouble(Console.ReadLine());
            double imc = p / (a * a);
            Console.WriteLine("IMC: " + imc);

            Console.WriteLine("Usando o IF");
            if (imc <= 19)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > 19 && imc <= 30)
            {
                Console.WriteLine("Peso Normal");
            }
            if (imc > 30)
            {
                Console.WriteLine("Sobrepeso");
            }

            Console.WriteLine("Usando o switch");

            switch (imc)
            {
               default:
                    break;
            }
        }
    }
}
