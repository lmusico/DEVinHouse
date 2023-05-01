using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex7
{
    public class ContaBancaria
    {
        public string NumeroConta;

        public const decimal SaldoMaximo = 1000;

        private decimal Saldo {get; set; }

        public void Depositar(decimal valor){
            if (valor > SaldoMaximo){
                Console.WriteLine("Saldo acima do máximo permitido.");
            }
            else {
                Saldo += valor;
                Console.WriteLine("Depósito efetuado com sucesso! Saldo:\nR$: "+Saldo);
            }
        }

        public bool Sacar(decimal valor){
            if (Saldo > valor){
                Saldo -= valor;
                Console.WriteLine("Saque efetuado com sucesso! Saldo restante:\nR$: "+Saldo);
                return true;
            }
            else{
                Console.WriteLine("Saldo insuficiente para saque. Saldo disponível\nR$: "+Saldo);
                return false;
            }
        }


    }
}