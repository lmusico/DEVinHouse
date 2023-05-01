using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex10
{
    public class ContaBancaria
    {
        
        private decimal saldo;

        private String transacoes = "";

        public void Depositar(decimal valor)
        {
            saldo += valor;
            transacoes += $"\n----------\nDepósito de R$:{valor}\nSaldo atual de R$:{saldo}\n----------\n";
        }

        public bool Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Valor insuficiente para saque.");
                transacoes += $"\n----------\nTentativa de saque de R$:{valor}\nSaldo atual de R$:{saldo}\n----------\n";
                return false;
            }
            else
            {
                saldo -= valor;
                transacoes += $"\n----------\nSaque de {valor}\nSaldo atual de R$:{saldo}\n----------\n";
                return true;
            }

        }


        public void GetTransacoes()
        {
            Console.WriteLine(transacoes);
        }
    }
}