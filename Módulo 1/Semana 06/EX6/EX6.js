// https://api.agify.io/?country_id=BR&name=thais

const nome = "Lucas"

const buscaIdade = async () => {
    const resposta = await fetch(`https://api.agify.io/?country_id=BR&name=${nome}`);
    const data = await resposta.json();
    console.log(data);
};

buscaIdade();