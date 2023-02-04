class Usuario {
    constructor(nome, email, senha) {
        this.nome = nome;
        this.email = email;
        this.senha = senha;
    }

    autenticar(emailInformado, senhaInformada) {
        return (this.email === emailInformado && this.senha === senhaInformada);
    }
}

const usuario1 = new Usuario ("Lucas", "lucas@lucas.com", "1234");
const formulario = document.getElementById("login");
const recado = document.getElementById("aviso");
formulario.addEventListener("submit", (event) => {
    console.log("Entrou no event listener")
    event.preventDefault();
    const email = event.target.email.value;
    const senha = event.target.senha.value;
    console.log(usuario1.autenticar(email, senha))
    if(usuario1.autenticar(email, senha)){
        recado.innerText = ("Login efetuado com sucesso");
        console.log("Login efetuado com sucesso")
    }
    else{
        recado.innerText = ("E-Mail ou senha incorretos");
        console.log("E-Mail ou senha incorretos");
    }
})



