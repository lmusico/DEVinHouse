export default class Funcionario {
    constructor(cpf, nomeCompleto, salario){
        this.cpf = cpf;
        this.nome = nomeCompleto;
        this.salario = salario;
        let soma = 0
        for(let a = 0; a < cpf.length; a++) {
            if (!isNaN(cpf[a])){
                soma += parseInt(cpf[a])
                // console.log(soma);
            }

        };
        if (soma%11 == 0){
            console.log(`O CPF ${cpf} é válido`)
        }
        else{
            console.log(`O CPF ${cpf} NÃO é válido`)
        }
        
    }
    for
    promover(aumento){
        this.salario *= 1+(parseInt(aumento)/100);
    }
}