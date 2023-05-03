using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackBanck.Models
{
    public abstract class Cliente
    {
        public string NumeroConta;

        public decimal Saldo;

        public string Endereco;

        public void ResumoCliente(){
            Console.WriteLine($"Número da conta: {NumeroConta}\nSaldo: {Saldo}\nEndereço: {Endereco}");
        }
    }
}