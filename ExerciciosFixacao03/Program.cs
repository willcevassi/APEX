using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numPre = new int[8] { 24, 76,89,93,99,65,12,25 };
            Console.WriteLine("Informe um número inteiro entre 1 e 100:");
            int numUsuario = Convert.ToInt32(Console.ReadLine());
            string status = "Não está";
            for (int i = 0; i < numPre.Length; i++)
            {
                if (numPre[i] == numUsuario)
                {
                    status = "Está";
                    break;
                }
            }
            Console.WriteLine("O número digitado " + status + " na lista " + String.Join("-", numPre));
            Console.WriteLine("Pressione qualquer tecla pra encerrar");
            Console.ReadKey();
        }
    }
}
