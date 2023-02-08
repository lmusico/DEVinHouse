function aprovarDadosCadastrais( cliente ) {
    return new Promise( (resolve, reject) => {
        if (cliente.cpf === 11111111111)
            resolve(true);
        else 
            reject(false);
    });
}

function aprovarValorSolicitado( cliente, valor ) {
    return new Promise( (resolve, reject) => {
        if (cliente.margem >= valor)
            resolve(true);
        else 
            reject(false);
    });
}

const cliente = { cpf: 11111111111, nome: 'Calleri', margem: 1000.0 };
const aprovacaoCadastro = aprovarDadosCadastrais(cliente);
const aprovacaoValor = aprovarValorSolicitado(cliente, 3000.0);

// continue com o tratamento dos resultados de ambas as promises...

Promise.all([aprovacaoCadastro, aprovacaoValor]).then((valores)=>{
    // const f1 = valores[0] === true;
    // const f2 = valores[1] === true;
    // (f1 && f2) ? console.log("Aprovado") : console.log("Reprovado");
    console.log("Aprovado")
}).catch(()=>console.log("Reprovado"));