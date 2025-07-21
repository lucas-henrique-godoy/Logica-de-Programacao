using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosCrisTech
{
    class ContaCorrente : ContaBancaria
    {
        public double LimiteChequeEspecial { get; set; }

        public void PodeSacar(double valor)
        {
            var podeSacar = Saldo + LimiteChequeEspecial >= valor;

            if (podeSacar) 
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("É possível sacar o valor solicitado: ");
                Console.WriteLine($"Valor  solicitado: R${valor}");
                Console.WriteLine($"Saldo + cheque especial: R${Saldo + LimiteChequeEspecial}   ");
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Não é possível sacar o valor solicitado: ");
                Console.WriteLine($"Valor  solicitado: R${valor}");
                Console.WriteLine($"Saldo + cheque especial: R${Saldo + LimiteChequeEspecial}   ");
                Console.WriteLine("--------------------------");
            }
        }
    }
}
