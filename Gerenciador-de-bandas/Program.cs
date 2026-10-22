using System;
using System.ComponentModel.Design;
using System.Threading;
// Programa para cadastrar e listar bandas prediletas

List<string> bandasRegistradas = new List<string>(); 
void Menu()
{
    Console.Clear(); 
    Console.WriteLine("1.Cadastrar banda");
    Console.WriteLine("2.Listar bandas");
    Console.WriteLine("3.Sair");

    Console.Write("\nEscolha uma opção: ");
    int opcoes = int.TryParse(Console.ReadLine()!, out int resultado) ? resultado : 0; 

    switch (opcoes) 
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
        default: 
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

void CadastrarBanda() 
{
    Console.Clear();
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda);
    Console.WriteLine($"Banda {nomeBanda} cadastrada com sucesso!");
    Thread.Sleep(1000);
}

void ListarBandas() 
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
while (true) 
{
    Menu();
}
