var num = parseInt(window.prompt("Entre com o valor inicial."));
var raiz = parseInt(window.prompt("Entre com o valor da raiz."));
var pa = [];

if(isNaN(num) || num === null){
    window.alert("Valor inválido.");
}
else{
    for(var i = 0; i<10; i++){
    pa.push(num+raiz*i);
    }
    window.alert(`Os 10 primeiros termos da sequência aritimética de início ${num} e raiz ${raiz} são: \n${pa}.`);
}
