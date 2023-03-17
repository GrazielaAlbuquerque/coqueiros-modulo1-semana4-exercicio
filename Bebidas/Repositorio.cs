
//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bebidas
{
    public static class Repositorio
    {
        public static List<Bebida> ListaBebidas {get; set; }
        public static List<Suco> ListaSuco {get; set; }
        public static List<Refrigerante> ListaRefrigerante {get; set;}


        static Repositorio()
        {
            if (ListaBebidas == null)
            {
                ListaBebidas = new List<Bebida>();
            }

            if (ListaSuco == null)
            {
                ListaSuco = new List<Suco>();
            }

            if (ListaRefrigerante == null)
            {
                ListaRefrigerante = new List<Refrigerante>();
            }
        }
        public static void AdicionarSuco(Suco suco)
            {
            Console.WriteLine("Você selecionou adicinar suco, vamos preencher algumas informações: ");
            Console.WriteLine("Qual o tamanho da caixa:");
            suco.TipoCaixa = Console.ReadLine();
            Console.WriteLine("Id:");
            suco.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo do suco:");
            suco.Tipo = Console.ReadLine();
            Console.WriteLine("Mililitros:");
            suco.MiliLitro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nome da bebida:");
            suco.NomeBebida = Console.ReadLine();
            Console.WriteLine("Valor:");
            suco.ValorCompra = decimal.Parse(Console.ReadLine());
            ListaSuco.Add(suco);
            Console.WriteLine($"Suco {suco.NomeBebida} adicionado.");
        }

        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {

            Console.WriteLine("Você selecionou adicinar refrigerante, vamos preencher algumas informações:");
            Console.WriteLine("Ele está em embalagem de vidro? Digite true ou false:");
            refrigerante.Vidro = bool.Parse(Console.ReadLine());
            Console.WriteLine("Id:");
            refrigerante.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de refrigerante:");
            refrigerante.Tipo = Console.ReadLine();
            Console.WriteLine("Mililitros:");
            refrigerante.MiliLitro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nome da bebida:");
            refrigerante.NomeBebida = Console.ReadLine();
            Console.WriteLine("Valor:");
            refrigerante.ValorCompra = decimal.Parse(Console.ReadLine());
            ListaRefrigerante.Add(refrigerante);
            Console.WriteLine($"Refrigerante {refrigerante.NomeBebida} adicionado.");
        }
 
        public static void InserirBebida(Bebida bebida)
        {
           
            Console.WriteLine("Você selecionou adicinar bebida, vamos preencher algumas informações: ");
            Console.WriteLine("Digite o ID:");
            bebida.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo de bebida:");
            bebida.Tipo = Console.ReadLine();
            Console.WriteLine("Quantidade em mililitros:");
            bebida.MiliLitro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da bebida:");
            bebida.NomeBebida = Console.ReadLine();
            Console.WriteLine("Valor (use vírgula para centavos):");
            bebida.ValorCompra = decimal.Parse(Console.ReadLine());
            ListaBebidas.Add(bebida);
            Console.WriteLine($"Bebida {bebida.NomeBebida} adicionada.");
        }
        public static void AlterarBebida(Bebida bebida)
        {
            if (ListaBebidas.Count > 0)
            {

                    Console.WriteLine("Informe o Id da bebida a ser alterada: ");
                    int buscarId = int.Parse(Console.ReadLine());
                    foreach (var item in ListaBebidas)
               {
                    if (item.Id == buscarId)
                    {
                        ListaBebidas.Remove(item);
                        Console.WriteLine("Vamos alterar a bebida: ");
                        bebida.Id = buscarId;
                        Console.WriteLine("Tipo: ");
                        bebida.Tipo = Console.ReadLine();
                        Console.WriteLine("MiliLitros: ");
                        bebida.MiliLitro = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Nome da bebida: ");
                        bebida.NomeBebida = Console.ReadLine();
                        Console.WriteLine("Valor de compra: ");
                        bebida.ValorCompra = decimal.Parse(Console.ReadLine());
                        ListaBebidas.Add(bebida);
                        Console.WriteLine("Bebida foi alterada!");
                        Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
                        Console.ReadLine();
                        Menu.DisplayInicial();

                    }
                    else { Console.WriteLine("ID não encontado."); }
                }
            }
            else { Console.WriteLine("Não contém itens na lista.");  }
        }
        
        public static void ExcluirBebida(int id)
      {
            Console.WriteLine("Digite o Id da bebida que deseja excluir");
            int buscaId = int.Parse(Console.ReadLine());
            foreach(var item in ListaBebidas)
            {
                if ( item.Id == buscaId)
                {
                    ListaBebidas.Remove(item);
                    Console.WriteLine($"Bebida {item.NomeBebida},de id {item.Id} removida com sucesso.");
                    Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
                    Console.ReadLine();
                    Menu.DisplayInicial();
                }
                else { Console.WriteLine("Não foi possível localizar o ID digitado."); }
            }

        }
        public static void ListarBebida(Bebida bebida)
        {
            foreach (var item in ListaBebidas)
            {
            Console.WriteLine("Id: " + item.Id);
            Console.WriteLine("Tipo: " + item.Tipo);
            Console.WriteLine("MiliLitros: " + item.MiliLitro);
            Console.WriteLine("Valor: " + item.ValorCompra);
            Console.ReadLine();
            return;
            }
        }
        public static void ListarSuco(Suco suco)
        {
            foreach (var item in ListaSuco)
            {
            Console.WriteLine("Tipo de Caixa: " + item.TipoCaixa);
            Console.WriteLine("Id: " + item.Id);
            Console.WriteLine("Tipo: " + item.Tipo);
            Console.WriteLine("MiliLitros: " + item.MiliLitro);
            Console.WriteLine("Valor: " + item.ValorCompra);
            Console.ReadLine();
            return;
            }
        }

        public static void ListarRefrigerante(Refrigerante refrigerante)
        {
            foreach (var item in ListaRefrigerante)
            {
            Console.WriteLine("Embalagem vidro: " + item.Vidro);
            Console.WriteLine("Id: " + item.Id);
            Console.WriteLine("Tipo: " + item.Tipo);
            Console.WriteLine("MiliLitros: " + item.MiliLitro);
            Console.WriteLine("Valor: " + item.ValorCompra);
            Console.ReadLine();
            return;
            }
        }

        public static void ImprimirSuco(Suco suco)
        {
            foreach (var item in ListaSuco)
            {
                suco.ImprimirDados();
            }
        }
        public static void ImprimirRefrigerante(Refrigerante refrigerante)
        {
            foreach (var item in ListaRefrigerante)
            {
                refrigerante.ImprimirDados();
            }
        }
    }
}