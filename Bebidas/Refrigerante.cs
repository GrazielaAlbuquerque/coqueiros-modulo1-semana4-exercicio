using Bebidas;

namespace Bebidas
{
    public class Refrigerante : Bebida
    {
        public bool Vidro{ get; set; }

       /* public Refrigerante (bool vidro, int id, string tipoBebida, decimal miliLitro, string nomeBebida, decimal valorCompra) : base (id, tipo, miliLitros, nomeBebida, valorCompra)
         { 
             Vidro = vidro;
             Tipo = "Refrigerante";
         }*/

        public void ImprimirRefrigerante()
        {
            if (Vidro == true)
            {   
                Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante com {MiliLitro} mL um vidro.");
            }
            else
            {
                Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante com {MiliLitro} ml em uma garrafa pet.");
            }
        }
    }
}