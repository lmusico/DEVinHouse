using FullStackBank.Services;

var cliente1 = new ClienteService();

Console.Clear();

string opcao = "0";

do
{
    Console.WriteLine("Entre com a opção desejada:\n1 - Abrir Conta\n2 - Consultar conta\n3 - Listar todas as contas\n4 - Sair");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        Console.Clear();
        cliente1.CriarConta();
        break;
        case "2":
        Console.Clear();
        Console.WriteLine("Digite o número de conta que deseja buscar:");
        string busca = Console.ReadLine();
        cliente1.BuscarClientePorNumeroDeConta(busca);
        break;
        case "3":
        Console.Clear();
        cliente1.ExibirClientes();
        break;
        case "4":
        Console.Clear();
        Console.WriteLine("Saindo do programa");
        break;
        default: 
        Console.Clear();
        Console.WriteLine("Opção inválida");
        break;
    }
} while (opcao != "4");