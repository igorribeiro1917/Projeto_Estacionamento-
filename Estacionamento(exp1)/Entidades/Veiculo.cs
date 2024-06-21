using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_exp1_.Entidades
{
    internal class Veiculo
    {
        public string Modelo { get; set; }

        public Veiculo(string modelo)
        {
            this.Modelo = modelo;
        }
    }
}
