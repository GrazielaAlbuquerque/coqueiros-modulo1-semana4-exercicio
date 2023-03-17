using System.ComponentModel;
using Bebidas;

bool showMenu = true;

Bebida bebida = new Bebida();
Suco suco = new Suco();
Refrigerante refrigerante = new Refrigerante ();
while (showMenu)
{
    Menu.DisplayInicial();
    var opcaoEscolhida = Menu.SelecionarOpcao();
    

    switch (opcaoEscolhida)
    {
        case 1:
            Repositorio.InserirBebida(bebida);
            break;

        case 2:
            Repositorio.AlterarBebida(bebida);
            break;

        case 3:
            Repositorio.ExcluirBebida(bebida.Id);
            break;

        case 4:
            Repositorio.ListarBebida(bebida);
            Menu.DisplayInicial();
            break;

        case 5:
            Repositorio.ListarSuco(suco);
            Menu.DisplayInicial();
            break;

        case 6:
            Repositorio.ListarRefrigerante(refrigerante);
            Menu.DisplayInicial();
            break;
        case 7:
            Console.Write("Obrigada pela preferência!"); 
            showMenu = false;           
            break;

        default:
            Console.WriteLine("Dados com erros, aguarde 3 segundos para a tela carregar o display inicial");
            Thread.Sleep(2000);
            Menu.DisplayInicial();
            break;
    }    
}

