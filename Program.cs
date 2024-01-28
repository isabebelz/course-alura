// Screen Sound 

using System.Diagnostics.CodeAnalysis;
using System.Runtime;

String mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
//List<String> bandas = new List<string> {"Red Hot Chili Peppers", "Motorhead", "Foo Fighters"};
//List<int> notaBanda = new List<int>(); 

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Red Hot Chili Peppers", new List<int> {10, 9, 10});
bandas.Add("Motorhead", new List<int>());

void ExibirLogo() {
    //verbatim literal '@'
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu() {
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica) {
        case 1: RegistrarBanda(); break;
        case 2: MostrarBanda(); break;
        case 3: AvaliarBanda(); break;
        case 4: ExibirMedia(); break;
        case -1: Console.WriteLine($"tchau tchau!"); break;
        default: Console.WriteLine("Opção inválida"); break;
    }
}

ExibirMenu();

void RegistrarBanda() {

    Console.Clear();
    ExibirTituloDaOpcao("Registrar Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBanda() {
    Console.Clear();
    ExibirTituloDaOpcao("Bandas Registradas");
    foreach(string banda in bandas.Keys) {
        Console.WriteLine($"{banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();

}

void ExibirTituloDaOpcao(string titulo) {

    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadRight(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asterisco}\n");

}

void AvaliarBanda() {
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.WriteLine("\nQual banda você quer avaliar?");

    
    string bandaEscolhida = Console.ReadLine()!;

    if(bandas.ContainsKey(bandaEscolhida)) {  
        Console.Write($"Digite uma nota para {bandaEscolhida}: ");         
        int nota = int.Parse(Console.ReadLine()!);
        bandas[bandaEscolhida].Add(nota);
        Console.WriteLine($"\nA banda {bandaEscolhida} recebeu a nota {nota}!\nVoltando ao menu principal...");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();

    }
    else {
        Console.WriteLine($"\nA banda {bandaEscolhida} ainda não foi registrada\nVoltando ao menu principal...");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    
}



void ExibirMedia() {

    Console.Clear();
    ExibirTituloDaOpcao("Média das avaliações");
    Console.Write("Digite o nome de uma banda: ");
    string bandaEscolhida = Console.ReadLine()!;

    if(bandas.ContainsKey(bandaEscolhida)) {
        Console.WriteLine($"A média das avaliações da banda {bandaEscolhida} é {bandas[bandaEscolhida].Average()}\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    } else {
        Console.WriteLine($"Banda {bandaEscolhida} não registrada\nVoltando ao menu...");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }

}



