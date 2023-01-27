var contas = []

const formulario = document.getElementById("cadastro");
formulario.onsubmit = (event) => {
    event.preventDefault();
    const nome = event.target.nome.value;
    const celular = event.target.celular.value;
    const cpf = event.target.cpf.value;
    const senha = event.target.senha.value;
    const senhac = event.target.senhac.value;
    const idconta = new Date().getTime()
    // console.log(nome, celular, cpf, senha, senhac)
    if (senha !== senhac){
        window.alert("A senha não bate com a confirmação.\nFavor corrigir e enviar novamente.");
    }
    else{
        const contaNova = {
            nome: nome,
            celular: celular,
            cpf: cpf,
            senha: senha,
            id: idconta,
            saldo: 0
        }
        contas.push(contaNova);
        console.log(contas);
        const contaCriada = document.getElementById("avisos");
        contaCriada.innerText = `Conta criada com sucesso!\nConta número:${idconta}`;
    }
}
const valor = document.getElementById("valor");

const desabilitaValor = document.getElementById("operacao");
desabilitaValor.onchange = (event) =>{
    if (desabilitaValor.value == 2){
        valor.disabled = true;
    }
    else{
        valor.disabled = false;
    }
}



