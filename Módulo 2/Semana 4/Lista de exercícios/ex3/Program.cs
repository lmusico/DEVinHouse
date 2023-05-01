using ex3;

Cliente cliente1 = new Cliente("Nome1", "123.123.123");

Console.WriteLine(cliente1.ToString());

ContaBancaria conta1 = new ContaBancaria("126.189-3", cliente1);

conta1.ExibirDados();

conta1.Depositar(20);

conta1.Sacar(10);

Console.WriteLine(conta1);
