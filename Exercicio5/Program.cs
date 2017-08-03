using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid;
            string strData;
            DateTime dtData;
            do
            {
                Console.WriteLine("Informe uma data:");
                strData = Console.ReadLine();
                isValid = validaData(strData);
                if (!isValid)
                {
                    Console.WriteLine("Data Inválida!");
                    Console.Read();
                }
            } while (!isValid);
            dtData = Convert.ToDateTime(strData);

            Console.WriteLine(String.Format("Mês por extenso: {0}", exibeMesExtenso(dtData)));
            Console.Read();

        }

        private static string exibeMesExtenso(DateTime dtData)
        {
            int mes = dtData.Month;
            string mesExtenso;
            switch (mes)
            {
                case 1:
                    mesExtenso =  "Janeiro";
                    break;
                case 2:
                    mesExtenso = "Fevereiro";
                    break;
                case 3:
                    mesExtenso = "Março";
                    break;
                case 4:
                    mesExtenso = "Abril";
                    break;
                case 5:
                    mesExtenso = "Maio";
                    break;
                case 6:
                    mesExtenso = "Junho";
                    break;
                case 7:
                    mesExtenso = "Julho";
                    break;
                case 8:
                    mesExtenso = "Agosto";
                    break;
                case 9:
                    mesExtenso = "Setembro";
                    break;
                case 10:
                    mesExtenso = "Outubro";
                    break;
                case 11:
                    mesExtenso = "Novembro";
                    break;
                case 12:
                    mesExtenso = "Dezembro";
                    break;
                default:
                    mesExtenso = "";
                    break;

            }

            return mesExtenso;
        }

        private static bool validaData(string strData)
        {
            DateTime toResult = new DateTime();
            CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
            DateTimeStyles styles = DateTimeStyles.AssumeLocal;
            return  DateTime.TryParse(strData, culture, styles, out toResult);
        }
    }
}
