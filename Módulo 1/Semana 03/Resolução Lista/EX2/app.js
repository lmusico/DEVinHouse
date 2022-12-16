const mensagemOla = (nome) => `Olá ${nome}`;

const entradaNome = document.getElementById('nome');
const botaoAcao = document.getElementById('acao');
const pMensagem = document.getElementById('mensagem');

// let ola = window.prompt("Qual o seu nome?");
// mensagemOla(ola);


botaoAcao.addEventListener("click", () => {
    const nome = entradaNome.value;
    const msg = mensagemOla(nome);
    pMensagem.innerHTML = msg;
    
})