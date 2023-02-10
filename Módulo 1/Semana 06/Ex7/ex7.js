const BASE_URL = "https://rickandmortyapi.com/api/character/";

const obterPersonagemAleatorio = async () => {
    const idAleatorio = Math.floor(Math.random()*826);
    const resposta = await fetch (`${BASE_URL}${idAleatorio}`);
    const dados = await resposta.json();
    return dados
    // console.log("Seu personagem aleatório é:",dados.name)
    // console.log("Foto do seu personagem:",dados.image)
}



const botao = document.getElementById("botaoGerar");
const mensagem = document.getElementById("mensagem");
const imagem = document.getElementById("imagem");
botao.addEventListener("click", async (event)=>{
    const personagem = await obterPersonagemAleatorio();
    mensagem.innerText = `Seu personagem de Rick and Morty é: ${personagem.name}`
    imagem.src = personagem.image
    console.log(personagem)
})