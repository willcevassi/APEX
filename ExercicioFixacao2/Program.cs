using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao2
{
    public class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Nome do Aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine("Nota do Aluno:");
            double nota = Convert.ToDouble(Console.ReadLine());
            string status = null;
            if (nota >= 7)
            {
                status = "Aprovado";
            }
            if (nota < 7 && nota >= 5)
            {
                status = "Em Recurepação";
            }
            else
            {
                status = "Reprovado";
            }

            Console.WriteLine(String.Format("A nota do Aluno {0} foi {1}, portanto seu status {2}"),nome, nota.ToString("N2"),status);
        }
    }
}
