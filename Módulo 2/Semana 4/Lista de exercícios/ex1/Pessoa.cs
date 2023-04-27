using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoaSpace
{
    public class Pessoa
    {
        private string nome;

        protected string idade;

        public string endereco;

        public Pessoa(string nome, string idade, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }

        public void Saudacao(){
            Console.WriteLine($"Olá, meu nome é {nome} e eu tenho {idade} anos");
        }
        
    }
}

/*

Crie uma classe chamada "Pessoa" com os seguintes atributos:

Nome (private)
Idade (protected)
Endereço (public)
Crie também um método público chamado "saudacao" que imprime no console a seguinte mensagem: "Olá, meu nome é {nome da pessoa} e eu tenho {idade} anos".

Passo a passo:

Crie uma classe chamada "Pessoa".
Dentro da classe "Pessoa", declare os atributos "nome", "idade" e "endereco" com os modificadores de acesso "private", "protected" e "public", respectivamente.
Crie um construtor para a classe "Pessoa" que receba como parâmetros os valores para os atributos "nome", "idade" e "endereco" e atribua esses valores aos respectivos atributos.
Crie um método público chamado "saudacao" que imprime no console a mensagem "Olá, meu nome é {nome da pessoa} e eu tenho {idade} anos".
Para testar a classe, crie um objeto "pessoa1" do tipo "Pessoa" e atribua valores para os atributos "nome", "idade" e "endereco". Em seguida, chame o método "saudacao" do objeto "pessoa1".

*/