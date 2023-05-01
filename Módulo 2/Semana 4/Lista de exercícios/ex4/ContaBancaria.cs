using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex4
{
    public class ContaBancaria
    {
        private decimal saldo;

        public void Depositar(decimal valor){
            saldo += valor;
            Console.WriteLine("Depósito efetuado com sucesso! Saldo:\nR$: "+saldo);
        }

        public bool Sacar(decimal valor){
            if (saldo > valor){
                saldo -= valor;
                Console.WriteLine("Saque efetuado com sucesso! Saldo restante:\nR$: "+saldo);
                return true;
            }
            else{
                Console.WriteLine("Saldo insuficiente para saque. Saldo disponível\nR$: "+saldo);
                return false;
            }
        }
    }
}