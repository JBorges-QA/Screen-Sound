// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

Dictionary<string, List<int>> Bandas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\n[1] - Registrar uma banda");
    Console.WriteLine("[2] - Mostrar todas as bandas");
    Console.WriteLine("[3] - Avaliar uma banda");
    Console.WriteLine("[4] - Exibir a média de uma banda");
    Console.WriteLine("[0] - Sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida =  Console.ReadLine()!;
    
    switch (int.Parse(opcaoEscolhida))
    {
        case 1: RegistrarBanda(); break;
        case 2: ExibirBandas(); break;
        case 3: AvaliarBanda(); break;
        case 4: ExibirMedia(); break;
        case 0: Console.WriteLine("Finalizando programa!"); break;
        default: Console.WriteLine("Opção inválida!!"); break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    TituloOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void ExibirBandas()
{
    Console.Clear();
    TituloOpcao("Exibindo todas as bandas registradas");
    int i = 1;
    //for (int i = 0; i < Bandas.Count; i++)
    //{
    //    Console.WriteLine($"[{i + 1}] - {Bandas[i]}");
    //}

    foreach (string Banda in Bandas.Keys)
    {
        Console.WriteLine($"[{i}] - {Banda}");
        i++;
    }
    Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();

}

void AvaliarBanda()
{
    Console.Clear();
    TituloOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (Bandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        Bandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {

    }

}

void TituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string decoracao = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(decoracao);
    Console.WriteLine(titulo);
    Console.WriteLine(decoracao + "\n");
}

void ExibirMedia()
{
    Console.Clear();
    TituloOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (Bandas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = Bandas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notas.Average()}");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

ExibirMenu();