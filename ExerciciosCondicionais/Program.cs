using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            string resp;
            if (idade >= 13 && idade < 19)
            {
                resp = "Adolescente";
            }
            else if (idade >= 19 && idade <= 60)
            {
                resp = "Adulto";
            }
            else if (idade > 60)
            {
                resp = "Idoso";
            }
            else
            {
                resp = "Criança";
            }
            Console.WriteLine(resp);
            Console.Read();
            Copa2014();
            Console.Read();

        }



        private static void Copa2014()
        {
            Console.WriteLine("Quem ganhou a copa do mundo de 2014 ???");
            Console.WriteLine("1. Brasil");
            Console.WriteLine("2. Argentina");
            Console.WriteLine("3. Alemanha");
            Console.WriteLine("4. Estados Unidos");
            Console.WriteLine("Digite sua resposta: ");
            string resp = Console.ReadLine();
            if (resp == "2")
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Errou");
            }

        }
    }
}
