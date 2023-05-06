using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FullStackBank.Models
{
    public class PessoaJuridica : Cliente
    {
        public string razaoSoc;

        public string cnpj;

        public PessoaJuridica(){
            Console.WriteLine("Entre com a razão social:");
            razaoSoc = Console.ReadLine();

            Console.WriteLine("Entre com seu CNPJ:");
            cnpj = Console.ReadLine();

            Console.WriteLine("Entre com seu Endereço:");
            Endereco = Console.ReadLine();

        }
        
        public override string ToString()
        {
            return $"\n--------------------\nNúmero da conta: {NumeroConta}\nTipo da conta: pessoa jurídica\nRazão social: {razaoSoc}\nCNPJ: {cnpj}\nEndereço: {Endereco}\n--------------------\n";
        }
    }
}