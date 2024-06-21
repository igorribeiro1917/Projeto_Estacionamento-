using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_exp1_.Serviços
{
    internal class TaxaServicoBrasil : ITaxaServico
    {
        public double Taxa(double renda)
        {
            if (renda <= 100)
            {
                return renda * 0.2;
            }
            else
            {
                return renda * 0.15;
            }
        }



    }
}
