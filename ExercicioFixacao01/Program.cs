using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pares = new List<int>();
            List<int> impar = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(String.Format("{0} é par",i));
                    pares.Add(i);
                }
                else
                {
                    Console.WriteLine(String.Format("{0} é impar",i));
                    impar.Add(i);
                }
            }

            Console.Write("Números pares: ");

            Console.Write(String.Join(",",pares));


            Console.WriteLine();
            Console.Write("Números impares: ");
            foreach (int n in impar)
            {
                Console.Write(String.Join(",",impar));
            }

            Console.Read();
        }
    }
}
