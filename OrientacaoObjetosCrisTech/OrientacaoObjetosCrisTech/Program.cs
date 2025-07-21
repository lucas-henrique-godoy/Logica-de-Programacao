
using OrientacaoObjetosCrisTech;


Cliente clienteA = new Cliente();
clienteA.Nome = "Lucas";
clienteA.CPF = "123456789";

Cliente clienteB = new Cliente();
clienteB.Nome = "Gabriel";
clienteB.CPF = "123456789";



ContaPoupanca contaPoupanca = new ContaPoupanca();

contaPoupanca.Titular = clienteA;
contaPoupanca.NumeroConta = "123456";
contaPoupanca.Agencia = "0001";
contaPoupanca.TaxaRendimento = 0.01;

contaPoupanca.Depositar(500);

contaPoupanca.AplicarRendimento();

contaPoupanca.MostrarDados();




ContaCorrente contaCorrente = new ContaCorrente
{
    NumeroConta = "001234-5",
    Agencia = "0001",
    Titular = clienteB,
    LimiteChequeEspecial = 500
};

contaCorrente.PodeSacar(100);
contaCorrente.MostrarDados();


Console.ReadKey();
