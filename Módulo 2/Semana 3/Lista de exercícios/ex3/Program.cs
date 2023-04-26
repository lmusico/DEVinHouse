using ProprietarioSpace;
using CarroSpace;

var proprietario1 = new Proprietario();
var proprietario2 = new Proprietario();
var proprietario3 = new Proprietario();
var carro1 = new Carro();
var carro2 = new Carro();
var carro3 = new Carro();
List<Carro> listaDeCarros = new List<Carro>();

proprietario1.nome = "Borion";

proprietario2.nome = "Giborn";

proprietario3.nome = "Dagusdir";

proprietario1.cpf = "749.132.440-19";

proprietario2.cpf = "858.316.640-40";

proprietario3.cpf = "399.105.240-74";

proprietario1.telefone = "123456";

proprietario2.telefone = "321456";

proprietario3.telefone = "123123";

carro1.proprietario = proprietario1;

carro2.proprietario = proprietario2;

carro3.proprietario = proprietario3;

listaDeCarros.Add(carro1);

listaDeCarros.Add(carro2);

listaDeCarros.Add(carro3);

CadastraCarros();

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

    Console.Write("Nome:");
    string nome = Console.ReadLine();

    Console.Write("CPF:");
    string cpf = Console.ReadLine();

    Console.Write("Telefone:");
    string telefone = Console.ReadLine();

    Proprietario proprietario = new Proprietario();
    proprietario.nome = nome;
    proprietario.cpf = cpf;
    proprietario.telefone = telefone;


    carro.proprietario = proprietario;

    listaDeCarros.Add(carro);

}


