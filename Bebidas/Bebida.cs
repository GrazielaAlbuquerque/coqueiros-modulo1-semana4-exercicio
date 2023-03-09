
using System.Data;

namespace Bebidas
{
    public class Bebida
    {
        public int Id {get; set;}
        public string Tipo { get; set;}
        //public string Refrigerante { get; set;}
        //public string Suco { get; set;}
        public decimal MiliLitro {get; set;}
        public string NomeBebida {get; set;}
        public decimal ValorCompra {get; set;}

        /*public Bebida (int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) 
        {
            Id = id;
            Tipo = tipo;
            MiliLitro = miliLitro;
            NomeBebida = nomeBebida;
            ValorCompra = valorCompra;
        }*/
        public virtual void Comprar(int Id, decimal ValorCompra)
        {
            Console.WriteLine($"Valor da compra do produto id {Id} foi alterado para {ValorCompra}.");
        }
    }
}