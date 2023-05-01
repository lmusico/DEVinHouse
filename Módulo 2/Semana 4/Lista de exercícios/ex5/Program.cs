using ex5;

Pessoa pessoa1 = new();

pessoa1.DefinirIdade(-4);

Console.WriteLine(pessoa1.GetIdade());

pessoa1.DefinirIdade(4);


Console.WriteLine(pessoa1.GetIdade());

pessoa1.DefinirNome("Asdrubal");


Console.WriteLine(pessoa1.GetNome());

pessoa1.DefinirNome("Jack");

Console.WriteLine(pessoa1.GetNome());