using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Estacionamento_exp1_.Entidades;
using Estacionamento_exp1_.Serviços;

namespace Estacionamento_exp1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.WriteLine("Modelo do Carro: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Data de Início(dd/MM/yyyy HH:mm): ");
            DateTime Comeco = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Data de Retorno(dd/MM/yyyy HH:mm): ");
            DateTime final = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Data data = new Data(Comeco, final, new Veiculo(modelo));

            Console.WriteLine("Entre com o preço por hora");
            double hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço por dia");
            double dia = double.Parse(Console.ReadLine());

            ServicoAluguel servicoaluguel = new ServicoAluguel(hora, dia, new TaxaServicoBrasil());

            servicoaluguel.ProcessaFatura(data);

            Console.WriteLine("Informação do Aluguel");
            Console.WriteLine(data.Fatura);

            Console.ReadLine();
        
        
        
        
        }
    }
}
