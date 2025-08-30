// StuartFy

string mensagemDeInicio = "\nBoas vindas ao StuartFy11, um aplicativo de músicas teste baseado em aprendizados de C#.";

// Uma das formas de isolar um código sem precisar copia-lo várias vezes é criando uma função 

void ExibirMensagemDeInicio()
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
ExibirMensagemDeInicio();
// Void nao retorna nada, parenteses serve para indicar uma função, as chaves servem para encapsular
// O @ é um Verbatim Literal, basicamente um termo para mostrar a string como ela irá ser vista na run

void Exibir_menu()
{
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
        case 1: Console.WriteLine("Registre a banda desejada");
            break;
        case 2: Console.WriteLine("Mostrando todas as bandas");
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
Exibir_menu();

