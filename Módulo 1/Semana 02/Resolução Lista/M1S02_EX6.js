var operacao = window.prompt("Qual operação deseja fazer: +, -, x ou /?");
var n1 = parseInt(window.prompt("Digite o primeiro número da operação: "));
var n2 = parseInt(window.prompt("Digite o segundo número da operação: "));
var resposta = 0;
var valido = true;

if (isNaN(n1) || n1 === null || isNaN(n2) || n2 === null){
    valido = false;
    }
else{
    switch (operacao) {
        case "+":
            resposta = n1 + n2;
            break;
        case "-":
            resposta = n1 - n2;
            break;
        case "x":
            resposta = n1 * n2;
            break;
        case "/":
            resposta = n1 / n2;
            break;
        default:
            valido = false;
            break;
        }
    }

if (valido){
    window.alert(`O resultado do seu cálculo é: ${resposta}`);
    }
else{
    window.alert("Operação inválida.");
}