using OrientacaoObjetosCrisTech;

ContaBancaria conta = new ContaBancaria();

conta.Titular = "Lucas";
conta.NumeroConta = "123456";
conta.Agencia = "0001";
conta.Saldo = 1000;


conta.Sacar(500);
conta.Depositar(1500);
conta.Sacar(10000);
conta.MostrarDados();
