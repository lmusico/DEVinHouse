
const somaTudo = (...valores) => {
    let soma = 0;
    console.log(valores);
    valores.forEach((item)=>{
        soma += item;
    })
    return soma;
}

resultado = somaTudo(1, 2, 3, 4);
console.log(`O resultado da soma é: ${resultado}`);