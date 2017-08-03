using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivosPag104
{
    class Program
    {
        static void Main(string[] args)
        {
            string strArquivo = "Alunos Interessados.txt";


            string strPathIn = Environment.CurrentDirectory + @"\Input";
            if (!Directory.Exists(strPathIn))
            {
                Directory.CreateDirectory(strPathIn);
            }
            
            string strPathOut = Environment.CurrentDirectory + @"\Output";
            if (!Directory.Exists(strPathOut))
            {
                Directory.CreateDirectory(strPathOut);
            }

            StreamWriter sw = new StreamWriter(strPathIn + "\\" + strArquivo);
            sw.AutoFlush = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("João");
            sb.AppendLine("Jairo");
            sb.AppendLine("Maria");
            sb.AppendLine("Carlos");
            sb.AppendLine("Juliana");
            sb.AppendLine("José");
            sb.AppendLine("Marcos");
            sw.Write(sb);
            sw.Close();

            StreamReader sr = new StreamReader(strPathIn + "\\" + strArquivo);
            List<string> nomes = new List<string>();
            while (!sr.EndOfStream)
            {
                string linha = sr.ReadLine();
                if (!string.IsNullOrEmpty(linha))
                    nomes.Add(linha);
            }

            //nomes.Sort();
            nomes = nomes.OrderBy(x => x.Substring(0)).ToList();

            sw = new StreamWriter(strPathOut + "\\" + strArquivo);
            sw.AutoFlush = true;
            sb = new StringBuilder();
            Console.WriteLine("Nomes Ordenados");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
                sb.AppendLine(nome);
            }
            sw.Write(sb);
            sw.Close();

            Console.Read();
        }
    }
}
