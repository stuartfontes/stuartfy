// StuartFy

string mensagemDeInicio = "\nBoas vindas ao StuartFy, um aplicativo de músicas teste baseado em aprendizados de C#.";
List<string> listaDasBandas = new List<string>{"u2","u3","u4"};

// Uma das formas de isolar um código sem precisar copia-lo várias vezes é criando uma função 

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗████████╗██╗░░░██╗░█████╗░██████╗░████████╗███████╗██╗░░░██╗
██╔════╝╚══██╔══╝██║░░░██║██╔══██╗██╔══██╗╚══██╔══╝██╔════╝╚██╗░██╔╝
╚█████╗░░░░██║░░░██║░░░██║███████║██████╔╝░░░██║░░░█████╗░░░╚████╔╝░
░╚═══██╗░░░██║░░░██║░░░██║██╔══██║██╔══██╗░░░██║░░░██╔══╝░░░░╚██╔╝░░
██████╔╝░░░██║░░░╚██████╔╝██║░░██║██║░░██║░░░██║░░░██║░░░░░░░░██║░░░
╚═════╝░░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░░░░░░░╚═╝░░░");
    Console.WriteLine(mensagemDeInicio);
}

// Void nao retorna nada, parenteses serve para indicar uma função, as chaves servem para encapsular
// O @ é um Verbatim Literal, basicamente um termo para mostrar a string como ela irá ser vista na run

void Exibir_menu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite: 1 para registrar uma banda;");
    Console.WriteLine("Digite: 2 para mostrar todas as bandas;");
    Console.WriteLine("Digite: 3 para avaliar uma banda;");
    Console.WriteLine("Digite: 4 para exibir a média de avaliações de uma banda;");
    Console.WriteLine("Digite: -1 para sair;");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhida2 = int.Parse(opcaoEscolhida);
    // A ! é para o ReadLine não entregar uma opção nula
    
    switch (opcaoEscolhida2)
    {
        case 1: RegistrarBanda();
            break;
        case 2: mostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Avalie a banda selecionada");
            break;
        case 4: Console.WriteLine("Essas são as notas já avaliadas");
            break;
        case -1: Console.WriteLine("\nAgradeço a utilização :) ");
            break;
        default: Console.WriteLine("Error 1: Opção inválida");
            break;
    
    }
}
    
    void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine("**********************");
        Console.WriteLine("\nRegistro de Bandas\n");
        Console.WriteLine("**********************\n");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso" +
                          $"\nRetornando ao menu;" +
                          $"\nAguarde...");
        listaDasBandas.Add(nomeDaBanda);
        Thread.Sleep(2000);
        Console.Clear();
        Exibir_menu();
    }

    void mostrarBandasRegistradas()
    {
        Console.Clear();
        Console.WriteLine("****************************");
        Console.WriteLine("\nExibindo bandas, Aguardade:\n");
        Console.WriteLine("*****************************");
        //for (int i = 0; i < listaDasBandas.Count; i++)
        //{
           // Console.WriteLine($"Banda: {listaDasBandas[i]}");
        // }
        Console.WriteLine("\nAs bandas registradas são\n");
        foreach (string banda in listaDasBandas)
        {
            Console.WriteLine($"{banda}\n");
        }
        Thread.Sleep(2000);
        Console.WriteLine("Pressione uma tecla para retornar ao Menu: ");
        Console.ReadKey();
        Console.Clear();
        Exibir_menu();

    }


    Exibir_menu();
    
    