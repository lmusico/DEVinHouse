num = 1000;
var multiplo = 0;
var primos = [];
var qprimos = 0;

for (var x = 1; x<=num; x++){
    multiplo=0;
    console.log(`x=${x}`);
    for (var y = 1; y <= x; y++){
        console.log(`y=${y}`);
        if ((x % y) == 0){
            multiplo++;
        }
        if (multiplo > 2){
            break
        }
        if (y == x && multiplo == 2){
            primos.push(y);
            qprimos++;
        }
    }
}

window.alert(`A quantidade de primos até o número ${num} é ${qprimos}.\nSão eles: ${primos}.`);

