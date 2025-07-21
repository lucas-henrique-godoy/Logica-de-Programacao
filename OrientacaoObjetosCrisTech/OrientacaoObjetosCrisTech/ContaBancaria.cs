

namespace OrientacaoObjetosCrisTech
{
    class ContaBancaria
    {
        public Cliente Titular { get; set; }
        public string NumeroConta { get; set; }
        public string Agencia  { get; set; }        
        public double Saldo {  get; protected set; }           
                



        public void Depositar(double valor)
        {
            this.Saldo += valor;
            Console.WriteLine($"Depósito de: {valor} realizado. Saldo atual: R${this.Saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor <= this.Saldo)
            { 
                this.Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado. Saldo tual: {this.Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Titular: {this.Titular.Nome} - CPF: {Titular.CPF}");
            Console.WriteLine($"Conta: {this.NumeroConta} - Agência: {this.Agencia}");
            Console.WriteLine($"Saldo: {this.Saldo}");
            Console.WriteLine("----------------------------------");
        }
    }
}
