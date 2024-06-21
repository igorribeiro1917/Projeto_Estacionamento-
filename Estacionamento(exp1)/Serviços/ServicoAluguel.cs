using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamento_exp1_.Entidades;

namespace Estacionamento_exp1_.Serviços
{
    internal class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private ITaxaServico _taxaServico;

        public ServicoAluguel(double precohora, double precodia, ITaxaServico _taxaservico)
        {
            this.PrecoHora = precohora;
            this.PrecoDia = precodia;
            this._taxaServico = _taxaservico;

        }
        public void ProcessaFatura(Data data)
        {
            double PagamentoBasico = 0.0;
            TimeSpan Duracao = data.DataFinal.Subtract(data.DataInicio);
            if (Duracao.TotalHours <= 12.0)
            {
                PagamentoBasico = PrecoHora * Math.Ceiling(Duracao.TotalHours);
            }
            else
            {
                PagamentoBasico = PrecoDia * Math.Ceiling(Duracao.TotalDays);
            }
            double taxa = _taxaServico.Taxa(PagamentoBasico);

            data.Fatura = new Fatura(PagamentoBasico, taxa);

        }


    }
}
