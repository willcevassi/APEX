using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLacosRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero qualquer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Contando... ");
            for (int i = n; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

            Console.WriteLine("Testando Numero Par");
            int y;
            do
            {
                Console.WriteLine("Informe um número");
                y = Convert.ToInt32(Console.ReadLine());
            } while (!testarNumeroPar(y));

            double x = y / 2;
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Repetição " + i);
            }

            string resp;
            do
            {
                Console.ReadLine();
                Console.WriteLine("Quem ganhou a última copa do mundo ?");
                Console.WriteLine("1. Brasil");
                Console.WriteLine("2. Argentina");
                Console.WriteLine("3. Alemanha");
                Console.WriteLine("4. Estados Unidos");
                Console.WriteLine("Digite sua resposta: ");
                resp = Console.ReadLine(); 
                Console.WriteLine("Errou!");
            } while (resp != "2");

            Console.WriteLine("Acertou!");
        }
        
        static bool testarNumeroPar(int n)
        {
            if(n % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
