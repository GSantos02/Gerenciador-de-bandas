using System;
using System.ComponentModel.Design;
using System.Threading;
// Programa para cadastrar e listar bandas prediletas

List<string> bandasRegistradas = new List<string>(); // Lista para armazenar as bandas cadastradas
void Menu()
{
    Console.Clear(); // Limpa a tela para exibir o menu
    Console.WriteLine("1. Cadastrar banda");
    Console.WriteLine("2. Listar bandas");
    Console.WriteLine("3. Sair");

    Console.Write("\nEscolha uma opção: ");
    int opcoes = int.Parse(Console.ReadLine()!); // Lê a opção escolhida pelo usuário

    switch (opcoes) // Verifica a opção escolhida e executa a ação correspondente
    {
        case 1:
            CadastrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            Console.WriteLine("Saindo...");
            Environment.Exit(0);
            break;
        default: // Caso a opção seja inválida, exibe uma mensagem de erro
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

void CadastrarBanda() // Função para cadastrar uma nova banda
{
    Console.Clear();
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda);
    Console.WriteLine($"Banda {nomeBanda} cadastrada com sucesso!");
    Thread.Sleep(1000);
}

void ListarBandas() // Função para listar as bandas cadastradas
{
    Console.Clear();
    Console.WriteLine("Bandas cadastradas:");

    for (int i = 0; i < bandasRegistradas.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {bandasRegistradas[i]}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}
while (true) // Loop infinito para manter o programa em execução até que o usuário escolha sair
{
    Menu();
}