using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class Banco
    {
        private double saldo;

        public void Sacar(double valor){
            saldo -= valor;
        }

        public void Depositar(double valor){
            saldo += valor;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}