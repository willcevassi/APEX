using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dataValida = false;
            DateTime dtNascimento = new DateTime();
            do
            {
                Console.WriteLine("Digite um Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe a data de nascimento dd/MM/yyyy");
                string strNascimento = Console.ReadLine();
                try
                {
                    dtNascimento = ConverterData(strNascimento);
                    dataValida = true;                    
                }
                catch (Exception)
                {
                    dataValida = false;
                    Console.WriteLine("A data digitada é inválida!");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente");
                } 
            } while (!dataValida);

            Console.WriteLine(String.Format("Data no formato dd/MM/yyyy: {0}", dtNascimento.ToShortDateString()));
            Console.WriteLine(String.Format("Data por externso {0}", dtNascimento.ToLongDateString()));
            Console.ReadKey();
        }

        private static DateTime ConverterData(string data)
        {
            DateTime toReturn;
            try
            {
                string strData = data;
                CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
                DateTimeStyles styles = DateTimeStyles.AssumeLocal;
                DateTime.TryParse(data,culture,styles,out toReturn);
            }
            catch (Exception)
            {
                throw;              
            }

            return toReturn;
        }
    }
}
