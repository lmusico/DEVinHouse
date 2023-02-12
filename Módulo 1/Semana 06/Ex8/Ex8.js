// Com base no json de retorno, monte uma página web, contendo os dados de usuários de
// sistema com foto, título, nome, sobrenome, e-mail e endereço completo.
const BASE_URL = "https://randomuser.me/api/?results=";




const criarSpan = (res) => {    
    const p = document.createElement("p");
    const span = document.getElementById("conteudo");
    p.innerText = res;
    span.appendChild(p);
  }

const criarImg = (res) => {    
    const p = document.createElement("img");
    const span = document.getElementById("conteudo");
    p.src = res;
    span.appendChild(p);
  }


const formulario = document.getElementById("form");
formulario.addEventListener("submit", async (event)=>{
    event.preventDefault();
    const quantidade = event.target.valor.value;
    const resposta = await fetch (`${BASE_URL}${quantidade}`);
    const dados = await resposta.json();
    dados.results.forEach((x) => {
        criarImg(x.picture.large);
        criarSpan(`Nome: ${x.name.title} ${x.name.first} ${x.name.last}`);
        criarSpan(`E-mail: ${x.email}`);
        criarSpan(`Endereço: ${x.location.street.name}, ${x.location.street.number}`);
        criarSpan(`-----------------------------------------------`);
        console.log(x)
    })
    }
    )