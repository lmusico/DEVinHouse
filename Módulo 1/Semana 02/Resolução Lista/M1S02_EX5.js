var num = 0;
var par = 0;
var impar = 0;

num = window.prompt("Entre com um número para saber quantos pares e ímpares exitem entre 0 e o número digitado: ");

for (var x = 0; x <= num; x++){
    console.log(x)
    if (x%2 == 0){par++;}
    else {impar ++;}
}

window.alert(`Número de ímpares: ${impar}\nNúmero de pares: ${par}`)