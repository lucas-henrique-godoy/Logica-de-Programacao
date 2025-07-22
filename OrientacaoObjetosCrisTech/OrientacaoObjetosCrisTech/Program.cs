using OrientacaoObjetosCrisTech;


Cliente clienteA = new Cliente();
clienteA.Nome = "Lucas";
clienteA.CPF = "123456789";

Cliente clienteB = new Cliente();
clienteB.Nome = "Henrique";
clienteB.CPF = "24681012";

ContaCorrente contaCorrente = new ContaCorrente
{
    Titular = clienteA,
    NumeroConta = "123456",
    Agencia = "0001",
    LimiteChequeEspecial = 500
};




ContaPoupanca contaPoupanca = new ContaPoupanca
{
    Titular = clienteB,
    NumeroConta = "654321",
    Agencia = "0002",
    TaxaRendimento = 0.01
};

contaCorrente.Depositar(500);
contaCorrente.Depositar(500, "OLÁ MUNDO");







Console.ReadKey();
