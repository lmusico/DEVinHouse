const pessoa = {
    nome: 'Ada',
    idade: 36,
    profissao: 'matemática'
  };

const olaPessoa = ({nome, idade, profissao}) => {
    console.log("Está é " + nome + ", tem " + idade, "anos e é "+ profissao+".");
};

olaPessoa(pessoa);