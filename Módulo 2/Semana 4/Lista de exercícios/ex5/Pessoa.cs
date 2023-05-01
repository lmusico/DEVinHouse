using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex5
{
    public class Pessoa
    {
        private string nome;

        private int idade;

        public string GetNome(){
            return nome;
        }

        public string DefinirNome(string valor){
            nome = valor;
            return nome;
        }
        public int GetIdade(){
            return idade;
        }

        public void DefinirIdade(int valor){
            if (valor <= 0){
                Console.WriteLine("Idade menor que zero!");
            }
            else {
                idade = valor;
            }
        }

    }
}