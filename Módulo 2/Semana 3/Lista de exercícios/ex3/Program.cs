using System.Linq.Expressions;
using ProprietarioSpace;
using CarroSpace;

var proprietario1 = new Proprietario();
var proprietario2 = new Proprietario();
var proprietario3 = new Proprietario();
var carro1 = new Carro();
var carro2 = new Carro();
var carro3 = new Carro();

string opcao = "0";

List<Carro> listaDeCarros = new List<Carro>();

// proprietario1.nome = "Borion";

// proprietario2.nome = "Giborn";

// proprietario3.nome = "Dagusdir";

// proprietario1.cpf = "749.132.440-19";

// proprietario2.cpf = "858.316.640-40";

// proprietario3.cpf = "399.105.240-74";

// proprietario1.telefone = "123456";

// proprietario2.telefone = "321456";

// proprietario3.telefone = "123123";

// carro1.proprietario = proprietario1;

// carro2.proprietario = proprietario2;

// carro3.proprietario = proprietario3;

// listaDeCarros.Add(carro1);

// listaDeCarros.Add(carro2);

// listaDeCarros.Add(carro3);


while (opcao != "3"){
    Console.WriteLine("Bem vindo ao sistema de controle de carros. Digite a opção desejada:\n1 - Cadastrar carro\n2 - Consultar carro\n3 - Sair");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
        CadastraCarros();
        break;
        case "2":
        ListarCarros();
        break;
        default:
        Console.WriteLine("Opção inválida. As opções são:\n1 - Cadastrar carro\n2 - Consultar carro\n3 - Sair");
        break;
    }

}

// CadastraCarros();

// ListarCarros();

void CadastraCarros()
{
    Carro carro = new Carro();

    Console.WriteLine("Bem vindo ao método de cadastro de carros. Entre com as seguintes informações:");

    Console.Write("Marca:");
    carro.marca = Console.ReadLine();

    Console.Write("Modelo:");
    carro.modelo = Console.ReadLine();

    Console.Write("Placa:");
    carro.placa = Console.ReadLine();

    Console.Write("Cor:");
    carro.cor = Console.ReadLine();

    Console.Write("Nome do proprietário:");
    string nome = Console.ReadLine();

    Console.Write("CPF do proprietário:");
    string cpf = Console.ReadLine();

    Console.Write("Telefone do proprietário:");
    string telefone = Console.ReadLine();

    Proprietario proprietario = new Proprietario();
    proprietario.nome = nome;
    proprietario.cpf = cpf;
    proprietario.telefone = telefone;


    carro.proprietario = proprietario;

    listaDeCarros.Add(carro);

}

void ListarCarros()
{
    foreach (var carro in listaDeCarros)
    {
        Console.WriteLine("\n----------------\n");
        Console.WriteLine("Marca:" + carro.marca);
        Console.WriteLine("Modelo:" + carro.modelo);
        Console.WriteLine("Placa:" + carro.placa);
        Console.WriteLine("Cor:" + carro.cor);
        Console.WriteLine("Dados do proprietario:\nNome:" + carro.proprietario.nome);
        Console.WriteLine("CPF:" + carro.proprietario.cpf);
        Console.WriteLine("Telefone:" + carro.proprietario.telefone);
    }
}




