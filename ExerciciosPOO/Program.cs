using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosPOO.Animais;

namespace ExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animais = new List<Animal>();

            Vaca vaca1 = new Vaca();
            vaca1.CadastrarAnimal("Vaca1", 2, "Holandeza",true);
            Vaca vaca2 = new Vaca();
            vaca1.CadastrarAnimal("Vaca2", 6, "Holandeza",false);
            Cachorro cao1 = new Cachorro();
            cao1.CadastrarAnimal("Thor", 2, "Hiskie Siberiano");
            Cachorro cao2 = new Cachorro();
            cao2.CadastrarAnimal("Pipoca", 2, "Poodle");
            Animais.Add(vaca1);
            Animais.Add(vaca2);
            Animais.Add(cao1);
            Animais.Add(cao2);

            Console.WriteLine("Sons...");
            foreach (Animal  animal in Animais)
            {
                Console.WriteLine(String.Format("O Animal é um {0}  e faz {1} ", animal.GetType().ToString(),animal.EmitirSom()));
            }
            Console.Read();

        }
    }
}
