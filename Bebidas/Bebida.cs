//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bebidas
{
    public class Bebida
    {
        public int Id {get; set; }
        public string Tipo {get; set; }
        public decimal MiliLitro {get; set; }
        public string NomeBebida {get; set; }
        public decimal ValorCompra {get; set; }

        public Bebida (int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra)
        {
            Id = id;
            Tipo = tipo;
            MiliLitro = miliLitro;
            NomeBebida = nomeBebida;
            ValorCompra = valorCompra;
        }

        public void Comprar()
        {
            Console.WriteLine($"Valor compra da bebida Id {Id} foi alterado para {ValorCompra}.");
        }

        public virtual void ImprimirDados()
        {
            Console.WriteLine($"O produto id {Id} é uma bebida com quantidade de {MiliLitro} MiliLitros");            
        }
    }
}