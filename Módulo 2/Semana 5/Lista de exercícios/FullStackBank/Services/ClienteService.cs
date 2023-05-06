using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackBank.Models;
using FullStackBank.Interfaces;

namespace FullStackBank.Services
{
    public class ClienteService : IClienteService
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static int id = 1;

        public void CriarConta(){
            Console.WriteLine("Criar Conta:\nDigite 1 para criar uma conta Pessoa Física\nDigite 2 para criar uma conta Pessoa Jurídica");
            string escolhaConta = Console.ReadLine();

            switch (escolhaConta)
            {
                case "1":
                    var contaF = new PessoaFisica();
                    if (contaF.EhMaior()){
                        // contaF.NumeroConta = DateTime.Now.Millisecond.ToString();
                        contaF.NumeroConta = (id).ToString();
                        id++;
                        listaClientes.Add(contaF);
                    }
                    else{
                        Console.WriteLine("Não foi possível criar a conta, cliente menor de idade.");
                    }
                    break;
                case "2":
                    var contaJ = new PessoaJuridica();
                    // contaJ.NumeroConta = DateTime.Now.Millisecond.ToString();
                    contaJ.NumeroConta = (id).ToString();
                    id++;
                    listaClientes.Add(contaJ);
                    break;
                default: Console.WriteLine("Escolha inválida"); break;
            }
        }

        public void BuscarClientePorNumeroDeConta(string busca){
            bool clienteEncontrado = false;
            Console.WriteLine($"\nBuscando conta número: {busca}\n");
            foreach (var item in listaClientes)
            {
                if (item.NumeroConta == busca){
                    Console.WriteLine(item);
                    clienteEncontrado = true;
                    break;
                }
            }
            if (!clienteEncontrado){
                Console.WriteLine("Cliente não encontrado");
            }

        }

        public void ExibirClientes(){
            Console.WriteLine("\nExibindo todos os clientes:\n");
            foreach (var item in listaClientes)
            {
                Console.WriteLine(item);
            }
        }
    }
}