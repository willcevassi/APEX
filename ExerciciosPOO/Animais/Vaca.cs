using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Animais

{
    class Vaca : Animal
    {

        public bool Leiteira { get; private set; }

        public void CadastrarAnimal(string nome, int idade, string raca, bool leiteira)
        {
            this.CadastrarAnimal(nome, idade, raca);
            this.Leiteira = leiteira;
        }

        public override void CadastrarAnimal(string nome, int idade, string raca)
        {
            base.Nome = nome;
            base.Idade = idade;
            base.Raca = raca;
        }

        public override string EmitirSom()
        {
            return ("Múuuuu...");
        }

        public override string ToString()
        {
            return "Vaca";
        }
    }
}
