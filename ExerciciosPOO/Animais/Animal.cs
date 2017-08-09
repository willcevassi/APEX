using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Animais
{
    public abstract class Animal
    {
        protected string Raca { get; set; }
        protected string Nome { get; set; }
        protected int Idade { get; set; }
       

        public abstract void CadastrarAnimal(string nome, int idade, string raca);
        public abstract string EmitirSom();
        
    }
        

}
