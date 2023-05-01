using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class Cliente
    {

        private string nomePrivate;

        private string cpfPrivate;

        public string nome { get => nomePrivate; }

        public string cpf { get => cpfPrivate; }

        public Cliente(string nome, string cpf)
        {
            this.nomePrivate = nome;
            this.cpfPrivate = cpf;
        }

        public override string ToString()
        {
            return ("Dados do cliente:\n\nNome:" + nomePrivate + "\nCPF:" + cpfPrivate);
        }
    }
}