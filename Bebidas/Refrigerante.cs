using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bebidas
{
    public class Refrigerante : Bebida
    {
        public bool Vidro{ get; set; }
        
        public Refrigerante()
        {
            
        }

       public Refrigerante (bool vidro, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) : base (id, tipo, miliLitro, nomeBebida,valorCompra)
         { 
             Vidro = vidro;
         }

        public void ImprimirDados()
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