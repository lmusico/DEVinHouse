using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class ContaBancaria
    {
        private string numero;

        private Cliente cliente;

        public ContaBancaria(string numero, Cliente cliente)
        {
            this.numero = numero;
            this.cliente = cliente;
        }

        public void ExibirDados(){
            Console.WriteLine("\nMétodo ExibirDados()");
            Console.WriteLine("Número da conta:" + numero);
            Console.WriteLine("Nome do cliente:" + cliente.nome);
            Console.WriteLine("CPF do cliente:" + cliente.cpf);
        }

        Banco banco1 = new Banco();

        public void Depositar(double valor){
            banco1.Depositar(valor);
        }

        public void Sacar(double valor){
            banco1.Depositar(valor);
        }

        public override string ToString()
        {
            return "\nDados da Conta Bancária:\nConta: " + numero + "\nNome:" + cliente.nome + "\nCPF:" + cliente.cpf;
        }
    }
}