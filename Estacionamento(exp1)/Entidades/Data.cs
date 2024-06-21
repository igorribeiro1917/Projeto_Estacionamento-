using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_exp1_.Entidades
{
    internal class Data
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public Data(DateTime datainicio, DateTime datafinal, Veiculo veiculo)
        {
            this.DataInicio = datainicio;
            this.DataFinal = datafinal;
            this.Veiculo = veiculo;
            this.Fatura = null;
        }

    }
}
