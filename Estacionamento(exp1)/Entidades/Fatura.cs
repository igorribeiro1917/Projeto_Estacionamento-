using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_exp1_.Entidades
{
    internal class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamentobasico, double taxa)
        {
            this.PagamentoBasico = pagamentobasico;
            this.Taxa = taxa;
        }
        public double PagamentoTotal()
        {
            return PagamentoBasico + Taxa;
        }
        public override string ToString()
        {
            return "Pagamento Básico: " + PagamentoBasico.ToString("F2") + "\nTaxa: " + Taxa.ToString("F2") + "\nPagamentoTotal: "+PagamentoTotal().ToString("F2");
        }



    }
}
