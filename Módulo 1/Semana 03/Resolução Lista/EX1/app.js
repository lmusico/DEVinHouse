const lista = [56, 65, 64, -3, 23, 42, -15, 65, 14, 32, 78, 70, 47];
// const lista = [];
// const lista = [1];
// const lista = [1, -1];
// const lista = null;
// const lista = [-2,-2,-2,-2];
// const lista = [20,10, 30];

function procuraMinMax(a){
    a.sort();
    let min = a[0];
    let max = a[a.length-1];
    const resultado = [min, max];
    return resultado;
}
console.log("a");
if (lista && lista.length != 0){

    let x = procuraMinMax(lista);
    window.alert(`Valor máximo do array é ${x[1]}.\nValor mínimo do array é ${x[0]}.`);

}else{
    window.alert("Não é possível encontrar.");
}

