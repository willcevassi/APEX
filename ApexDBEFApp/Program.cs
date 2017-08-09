using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexDBEFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ApexDBEntityFramework contexto = new ApexDBEntityFramework();
            List<CLIENTES> clientes =  contexto.CLIENTES.OrderBy(X => X.NOME).ToList();
            Console.WriteLine(String.Format("Total de Clientes Cadastrados: {0}", clientes.Count));
            Console.WriteLine("====================================================");
            foreach (CLIENTES cliente in clientes)
            {
                
                Console.WriteLine(String.Format("Código: {0}", cliente.ID));
                Console.WriteLine(String.Format("Nome: {0}", cliente.NOME));
                Console.WriteLine(String.Format("Endereço: {0}", cliente.ENDERECO));
                Console.WriteLine(String.Format("Cidade {0}", cliente.CIDADE));
                Console.WriteLine("====================================================");
                Console.WriteLine(String.Format("Total de Pedidos do cliente: {0}", cliente.PEDIDOS.Count));
                Console.WriteLine(String.Format("Total de Compras do cliente: {0}", cliente.PEDIDOS.Sum(x => x.VALOR)));
                Console.WriteLine("====================================================");
                Console.WriteLine();
            }
            Console.Read();

            CLIENTES novo = new CLIENTES();
            novo.NOME = "João da Silva";
            novo.ENDERECO = "Rua x N. 35";
            novo.DATA_NASCIMENTO = new DateTime(1981, 03, 25);
            novo.CIDADE = "Florianópolis";
            contexto.Entry(novo).State = System.Data.EntityState.Modified;
            contexto.CLIENTES.Add(novo);
            contexto.SaveChanges();
            Console.Read();


            try
            {
                CLIENTES cli1 = new CLIENTES();
                cli1.NOME = "Maria2";
                cli1.ENDERECO = "Endereco da Maria";
                cli1.DATA_NASCIMENTO = new DateTime(1978, 02, 01);
                cli1.CIDADE = "Curitiba";


                PEDIDOS pedido = new PEDIDOS();
                pedido.CLIENTES = cli1;
                pedido.DATA_PEDIDO = new DateTime(2017, 08, 08);
                pedido.VALOR = 120;
               // contexto.Entry(cli1).State = System.Data.EntityState.Modified;
               // cli1.PEDIDOS.Add(pedido);
              //  contexto.Entry(pedido).State = System.Data.EntityState.Modified;
                contexto.PEDIDOS.Add(pedido);
                contexto.SaveChanges();
                Console.Read();
            }
            catch (System.Data.OptimisticConcurrencyException)
            {
       
                throw;
            }
        }
    }
}
