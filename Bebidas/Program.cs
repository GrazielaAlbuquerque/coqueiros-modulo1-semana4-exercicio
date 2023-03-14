using Bebidas;

//int opcaoEscolhida = 0;
bool showMenu = true;

while (showMenu)
{
    Menu.DisplayInicial();
    var opcaoEscolhida = Menu.SelecionarOpcao();
    
    //Bebida bebida = new Bebida(1, "Cerveja", 10,"Patagonia", 10);

    switch (opcaoEscolhida)
    {
        case 1:
            Bebida bebida = new Bebida(1, "Cerveja", 10,"Patagonia", 10);
            Repositorio.InserirBebida(bebida);
            Console.WriteLine("Você escolheu 'Inserir Bebida'! Precisamos coletar algumas informações:");            
            Menu.DisplayInicial();
            break;

        case 2:
            Bebida bebida1 = new Bebida(1, "Cerveja", 10,"Patagonia", 10);
            Console.WriteLine("Você escolheu 'Alterar Bebida'! Precisamos coletar algumas informações:");
            Repositorio.AlterarBebida(bebida1);
            Menu.DisplayInicial();
            break;

        case 3:
            Bebida bebida2 = new Bebida(1, "Cerveja", 10,"Patagonia", 10);
            Console.WriteLine("Você escolheu 'Excluir Bebida'! Informe o Id da bebida:");
            Repositorio.ExcluirBebida(bebida2.Id);
            Menu.DisplayInicial();
            break;

        case 4:
            Console.WriteLine("Você escolheu 'Listar todas as bebidas'!");
            Repositorio.ListarBebida();
            Menu.DisplayInicial();
            break;

        case 5:
            Console.WriteLine("Você escolheu 'Listar todos os sucos'!");
            Repositorio.ListarSuco();
            Menu.DisplayInicial();
            break;

        case 6:
            Console.WriteLine("Você escolheu 'Listar todos os refrigerantes'!");
            Repositorio.ListarRefrigerante();
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

