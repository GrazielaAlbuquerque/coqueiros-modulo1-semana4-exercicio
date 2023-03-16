using Bebidas;

//int opcaoEscolhida = 0;
bool showMenu = true;

Bebida bebida = new Bebida(1, "Cerveja", 10,"Patagonia", 10);
while (showMenu)
{
    Menu.DisplayInicial();
    var opcaoEscolhida = Menu.SelecionarOpcao();
    
    //Bebida bebida = new Bebida(1, "Cerveja", 10,"Patagonia", 10);

    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("Você escolheu 'Inserir Bebida'! Precisamos coletar algumas informações:");  
            Repositorio.InserirBebida(bebida);
   //         Menu.DisplayInicial();
            break;

        case 2:
            Console.WriteLine("Você escolheu 'Alterar Bebida'! Precisamos coletar algumas informações:");
            Repositorio.AlterarBebida(bebida);
            Console.ReadLine();
            //Menu.DisplayInicial();
            break;

        case 3:
            Console.WriteLine("Você escolheu 'Excluir Bebida'! Informe o Id da bebida:");
            Repositorio.ExcluirBebida(bebida.Id);
           // Menu.DisplayInicial();
            break;

        case 4:
            Console.WriteLine("Você escolheu 'Listar todas as bebidas'!");
            Repositorio.ListarBebida();
            //Menu.DisplayInicial();
            break;

        case 5:
            Console.WriteLine("Você escolheu 'Listar todos os sucos'!");
            Repositorio.ListarSuco();
            //Menu.DisplayInicial();
            break;

        case 6:
            Console.WriteLine("Você escolheu 'Listar todos os refrigerantes'!");
            Repositorio.ListarRefrigerante();
           // Menu.DisplayInicial();
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

