using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExercicio2
{
    class Program
    {
        static void Main(string[] args)

        {
            string op = "S";
            do
            {
                Console.WriteLine("Digite um numero: ");
                try
                {

                    int numero = Convert.ToInt32(Console.ReadLine());
                    if (numero < 10)
                    {
                        throw new ValorMuitoBaixoException("Ops, assim não é divertido!");
                    }
                    else if (numero > 10000)
                    {
                        throw new ValorMuitoAltoExemption("Ops, muita coisa! Vai com calma");
                    }

                    for (int i = 0; i < numero; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Voce quer fazer de novo: ");
                op = Console.ReadLine().ToUpper();
                Console.Clear();
                Console.BackgroundColor = (ConsoleColor)((new Random().Next(1,16)) % 16);
            } while (op == "S");
        }
    }
}
