
using OrientacaoObjetosCrisTech;


Cliente cliente = new Cliente();

cliente.Nome = "Lucas";
cliente.CPF = "123456789";


ContaBancaria conta = new ContaBancaria();

conta.Titular = cliente;
conta.NumeroConta = "123456";
conta.Agencia = "0001";

conta.MostrarDados();
