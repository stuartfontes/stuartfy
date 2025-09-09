// StuartFy

string mensagemDeInicio = "\nBoas vindas ao StuartFy, um aplicativo de músicas teste baseado em aprendizados de C#.";
//List<string> listaDasBandas = new List<string>{"u2","u3","u4"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("C#", new List<int>() { 1, 2, 3 });
bandasRegistradas.Add("tatAtA", new List<int>());
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
        case 3: avaliarUmaBanda();
            break;
        case 4: mediaDeBandas();
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
        ExibirTituloDaOpcao("Registro das Bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso" +
                          $"\nRetornando ao menu;" +
                          $"\nAguarde...");
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Thread.Sleep(2000);
        Console.Clear();
        Exibir_menu();
    }

    void mostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo as bandas registradas");
        //for (int i = 0; i < listaDasBandas.Count; i++)
        //{
           // Console.WriteLine($"Banda: {listaDasBandas[i]}");
        // }
        Console.WriteLine("\nAs bandas registradas são\n");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"{banda}\n");
        }
        Thread.Sleep(2000);
        Console.WriteLine("Pressione uma tecla para retornar ao Menu: ");
        Console.ReadKey();
        Console.Clear();
        Exibir_menu();

    }

    void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.Write(asteriscos + "\n");
        Console.Write(titulo + "\n");
        Console.Write(asteriscos + "\n");
    }

    string avaliarUmaBanda()
    {
        //Digite qual banda deseja avaliar
        // Se a banda existir atribuir uma nota
        // Se não, voltar ao menu principal
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar bandas registradas");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"A banda {nomeDaBanda} foi selecionada com sucesso;");
        Console.WriteLine("Iniciando avaliação da banda;\n");
        Thread.Sleep(2000);
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual a nota deseja atribuir a banda {nomeDaBanda}: ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.Write($"Registrando nota {nota};\nAguarde...\n");
            Thread.Sleep(2000);
            Console.Write($"A nota {nota} foi registrada para a banda {nomeDaBanda}");
            Thread.Sleep(5000);
            Console.Clear();
            Exibir_menu();
            return nota.ToString();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada:");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal;");
            Console.ReadKey();
            Console.Clear();
            Exibir_menu();
        }
        return string.Empty;
    }
    void mediaDeBandas()
    {
    Console.Clear();
    ExibirTituloDaOpcao("Media de bandas registradas");
    Console.Write("\nDigite o nome da banda que deseja visualizar a média de avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A banda {nomeDaBanda} foi escolhida com sucesso;\n");
        Thread.Sleep(2000);
        Console.WriteLine($"Canculando a média de avaliações da banda {nomeDaBanda};\nAguarde...\n");
        Thread.Sleep(2000);
        Console.Clear();
        Console.Write($"A média de notas da banda {nomeDaBanda}: é {notas.Average()}");
        Console.WriteLine("Pressione alguma tecla para retornar ao menu principal;\n");
        Console.ReadKey();
        Thread.Sleep(2000);
        Console.Clear();
        Exibir_menu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada:");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal;");
        Console.ReadKey();
        Thread.Sleep(2000);
        Console.Clear();
        Exibir_menu();
    }
    }

    Exibir_menu();
    
    