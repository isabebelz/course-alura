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

    ////Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    ////Console.Clear();
    ExibirMenu();
}

void MostrarBanda() {
    //Console.Clear();
    Console.WriteLine("Bandas");
    foreach(string banda in bandas) {
        Console.WriteLine($"{banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    //Console.Clear();
    ExibirMenu();

}

void AvaliarBanda() {
    //Console.Clear();
    Console.WriteLine("Avaliar Banda");
    Console.Write("\nQual banda você quer avaliar?");

    
    string avaliarBanda = Console.ReadLine()!;


    for(int i = 0; i < bandas.Count; i++) {
        if(avaliarBanda.Equals(bandas[i])) {           
            int nota = Console.Read();
            notaBanda.Insert(i, nota);
            Console.WriteLine($"A banda {bandas[i]} recebeu a nota {notaBanda[i]}!");
            Console.WriteLine(notaBanda[i]);
        }
    }
    
}
void ExibirMedia() {

}



