using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bebidas
{
    public class Suco : Bebida
    {
        public string TipoCaixa {get; set;}

       // public Suco (string tipoCaixa, int id, string tipoBebida, decimal miliLitro, string nomeBebida, decimal valorCompra) : base (id, tipoBebida, miliLitro, nomeBebida, valorCompra);            TipoCaixa = tipoCaixa;

        public void ImprimirSuco()
        {
            Console.WriteLine($"O produto id {Id} um suco do tipo {TipoCaixa} com quantidade de {MiliLitro} ml.");
        }
    }
}