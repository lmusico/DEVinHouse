var num = 0;
var soma = 0;

while(num != -1){
    soma += parseInt(num);
    num = window.prompt("Entre com um número para a soma. Digite -1 para finalizar.")
}

window.alert(`A soma dos números é: ${soma}`);