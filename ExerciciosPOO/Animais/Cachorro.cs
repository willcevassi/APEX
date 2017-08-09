using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Animais
{
    class Cachorro : Animal
    {
        public override void CadastrarAnimal(string nome, int idade, string raca)
        {
            base.Nome = nome;
            base.Idade = idade;
            base.Raca = raca;
        }

        public override string EmitirSom()
        {
            return "Au AU Au...";
        }
    }
}
