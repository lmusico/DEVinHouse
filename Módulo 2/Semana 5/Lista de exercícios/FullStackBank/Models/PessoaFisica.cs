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

        public PessoaFisica(){
            Console.WriteLine("Entre com sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu CPF:");
            cpf = Console.ReadLine();

            Console.WriteLine("Entre com seu Endereço:");
            Endereco = Console.ReadLine();

        }
        

        public bool EhMaior(){
            return idade >= 18;
        }

        public override string ToString()
        {
            return $"\n--------------------\nNúmero da conta: {NumeroConta}\nTipo da conta: pessoa física\nIdade: {idade}\nCPF: {cpf}\nEndereço: {Endereco}\n--------------------\n";
        }
        
        
    }
}