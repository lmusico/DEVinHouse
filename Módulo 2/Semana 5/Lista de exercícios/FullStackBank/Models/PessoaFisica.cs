using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackBank.Models
{
    public class PessoaFisica : Cliente
    {
        public int idade;

        public string cpf;

        public PessoaFisica(int idade, string cpf)
        {
            this.idade = idade;
            this.cpf = cpf;
        }

        public bool EhMaior(){
            return idade >= 18;
        }

        
    }
}