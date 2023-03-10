using Bebidas;

Menu.DisplayInicial();
Menu.SelecionarOpcao();

bool manterMenuAberto = true;

while (manterMenuAberto)
{
    //string opcao;

    switch (opcao)
    {
        
        case 1: //Acionar Bebida
            Bebida bebida = new Bebida ();
            bebida.Id = 1;
            bebida.Tipo = "Cerveja";
            bebida.MiliLitro = 350;
            bebida.NomeBebida = "Patagônia";
            bebida.ValorCompra = 13;
            Repositorio.AdicionarBebida(bebida);
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;
        case 2: //Alterar Bebida
            Bebida bebidaA = new Bebida ();
            bebidaA.Id = 1;
            bebidaA.Tipo = "Cerveja";
            bebidaA.MiliLitro = 350;
            bebidaA.NomeBebida = "Patagônia";
            bebidaA.ValorCompra = 13;
            Repositorio.AlterarBebida(bebidaA);
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;
        case 3: //Excluir bebida
            Bebida bebidaE = new Bebida ();
            bebidaE.Id = 1;
            Repositorio.ExcluirBebida();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;
        case 4: // Listar todas as bebidas
            Repositorio.ListaBebidas();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;
        case 5: // Listar todos sucos
            Repositorio.ListaSuco();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;
        case 6: // Listar todos refrigerantes
            Repositorio.ListaRefrigerante();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;
        case 7:
            Console.WriteLine("Tchau !!!");
            manterMenuAberto = false;
            break;
        default:
            //Erro no sistema, espero por 5 milissegundos
            Console.WriteLine("Dados com erros, aguarde 5 milissegundos para a tela carregar display inicial");
            Thread.Sleep(5000);
            Menu.DisplayInicial();
            break;
    }
}

/*Bebida bebida = new Bebida ();
Suco suco  = new Suco();
Refrigerante refrigerante  = new Refrigerante ();


Repositorio.AlterarBebida(bebida);


var listaAntesExcluir = Repositorio.Listar();


Repositorio.ExcluirBebida(1);


var listaApoxExcluir = Repositorio.Listar();


Repositorio.AdicionarBebida(bebida);
Repositorio.AdicionarSuco(suco);
Repositorio.AdicionarRefrigerante(refrigerante);


Repositorio.ImprimirRefrigerante();
Repositorio.ImprimirSuco();*/