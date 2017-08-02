using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVariaveisIndexadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meuArray = new int[]
            {
                23,
                12,
                456,
                34,
                11,
                89,
                45,
                77,
                38,
                19
            };

            List<int> lista = new List<int>();
            for (int i = 0; i < meuArray.Length; i++)
            {
                lista.Add(meuArray[i] * 10);

            }

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            string[,] minhaMatriz2D = new string[5, 2];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(String.Format("Informe o nome da Pessoa {0}",i + 1 ));
                minhaMatriz2D[i, 0] = Console.ReadLine();
                Console.WriteLine(String.Format("Informe o sobrenome da Pessoa {0}", i + 1));
                minhaMatriz2D[i, 1] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(minhaMatriz2D[i,0] + " " + minhaMatriz2D[i,1]);
            }
            Console.Read();
        }
    }
}
