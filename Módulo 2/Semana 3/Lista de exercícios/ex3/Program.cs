using ProprietarioSpace;
using CarroSpace;

var proprietario1 = new Proprietario();
var proprietario2 = new Proprietario();
var proprietario3 = new Proprietario();
var carro1 = new Carro();
var carro2 = new Carro();
var carro3 = new Carro();

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
