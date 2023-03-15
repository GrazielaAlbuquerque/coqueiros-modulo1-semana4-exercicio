using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bebidas
{
    public static class Menu
    {
        public static void DisplayInicial()
        {
         //   Console.Clear(); 
            Console.WriteLine("\n"); 
            Console.WriteLine("LOJA DE BEBIDAS:"); 
            Console.WriteLine("*******************************************************"); 
            Console.WriteLine("\n"); 
        }

        public static int SelecionarOpcao()
        {
           try
           {
                Console.WriteLine("Selecione a opção desejada :");
                Console.WriteLine("1 - Inserir Bebida");
                Console.WriteLine("2 - Alterar Bebida");
                Console.WriteLine("3 - Excluir Bebida");
                Console.WriteLine("4 - Listar Todas as Bebidas");
                Console.WriteLine("5 - Listar Todos os Sucos");
                Console.WriteLine("6 - Listar Todos os Refrigerantes");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("\n");
                
                Console.WriteLine("Opção :");
                return Convert.ToInt32(Console.ReadLine());
            }
          catch (Exception /*ex*/)
           {
                Console.WriteLine("Opção com erro, selecione a correta");
                Console.ReadLine();
            }

           return SelecionarOpcao();
        }

        public static bool ReiniciarDisplayConsole()
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Deseja reiniciar o menu: ");
            Console.WriteLine("1 - Sim.");
            Console.WriteLine("2 - Não.");
            Console.WriteLine("\n");

            Console.WriteLine("Opção :");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Menu.DisplayInicial();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}