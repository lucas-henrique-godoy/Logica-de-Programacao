using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosCrisTech
{
    class ContaPoupanca : ContaBancaria
    {
        public  double TaxaRendimento { get; set; }


        public void AplicarRendimento()
        {
            double rendimento = Saldo * TaxaRendimento;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de R${rendimento} aplicado. Saldo atual: R${Saldo}");
        }

        public override void MostrarDados()
        {
            Console.WriteLine("----------------Dados------------------");
            Console.WriteLine($"Titular: {this.Titular.Nome} - CPF: {Titular.CPF}");
            Console.WriteLine($"Conta: {this.NumeroConta} - Agência: {this.Agencia}");
            Console.WriteLine($"Taxa de Rendimento: {TaxaRendimento}");
            Console.WriteLine($"Saldo: {this.Saldo}");
            Console.WriteLine("----------------------------------");
        }
    }
}
