// Screen Sound 

using System.Diagnostics.CodeAnalysis;
using System.Runtime;

String mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
List<String> bandas = new List<string>();
List<int> notaBanda = new List<int>(); 


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
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
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

ExibirLogo();
ExibirMenu();

void RegistrarBanda() {

    Console.Clear();
    ExibirTituloDaOpcao("Registrar Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBanda() {
    Console.Clear();
    ExibirTituloDaOpcao("Bandas Registradas");
    foreach(string banda in bandas) {
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
    Console.Write("\nQual banda você quer avaliar?");

    
    string avaliarBanda = Console.ReadLine()!;


    for(int i = 0; i < bandas.Count; i++) {
        if(avaliarBanda.Equals(bandas[i])) {  
            Console.WriteLine($"Digite uma nota para {avaliarBanda}: ");         
            string nota = Console.ReadLine()!;
            notaBanda.Insert(i, int.Parse(nota));
            Console.WriteLine($"\nA banda {bandas[i]} recebeu a nota {notaBanda[i]}!");
        }
    }
    
}



void ExibirMedia() {

}



