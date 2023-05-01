using ex10;

ContaBancaria conta1 = new();

conta1.Depositar(20);

conta1.Sacar(30);

conta1.Sacar(15);

conta1.Depositar(19);

conta1.Depositar(70);

conta1.GetTransacoes();

Console.WriteLine(conta1.saldo);