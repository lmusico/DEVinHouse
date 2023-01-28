const contas = []

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
};


// Validação dasa operações bancárias
const operacoes = document.getElementById("operacoes");
operacoes.onsubmit = (event) => {
    event.preventDefault();
    let contavalida = false;
    let senhavalida = false;
    let validacao = false;
    const conta = document.getElementById("conta").value;
    const operacao = document.getElementById("operacao").value;
    const senhaop = document.getElementById("senhaop").value;
    const valor = parseInt(document.getElementById("valor").value);
    for (let n in contas){
        // console.log(contas[n].id);
        // console.log("conta digitada:", conta);
        if (contas[n].id == conta){
            contavalida = true;
            if (contavalida){
                if (contas[n].senha == senhaop){
                    senhavalida = true;
                    var contaN = n
                }
            }
            break
        }
    }
    if (contavalida == false){
        window.alert("Número de conta inválida.")
    }
    else if (!senhavalida){
        window.alert("Senha inválida.")
    }
    else {
        window.alert("Número de conta e senha validados com sucesso!")
        validacao = true;
    }

    if (validacao){
        switch (operacao){
            case "0":
                saque(contaN);
                break
            case "1":
                deposito(contaN, valor);
                break
            case "2":
                saldo(contaN);
                break
        }
    }
};

// Funções das operações
const saque = () => {
    console.log("Função saque");
};

const deposito = (conta, valor) => {
    const saldo = contas[conta].saldo;
    contas[conta].saldo += valor;
    window.alert(`Depósito realizado com sucesso!\n
Saldo anterior: R$ ${saldo}\n
Valor do depósito: R$ ${valor}\n
Saldo atual: R$ ${contas[conta].saldo}\n
Depósito realizado: ${new Date()}`)
    console.log("Função depósito");
};

const saldo = (conta) => {
    window.alert(`
Conta: ${contas[conta].id}\n
Saldo: R$ ${contas[conta].saldo}\n
Consulta realizada: ${new Date()}`)
    console.log("Função saldo");
};