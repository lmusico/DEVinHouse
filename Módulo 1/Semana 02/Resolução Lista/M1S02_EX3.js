var num = window.prompt("Insira o número cuja tabuada deseja saber: ");
var tabuada = [];

for (let i = 0; i <= 10; i++){
    tabuada[i] = i * num;
}

window.alert(
    "0 x " + num + " = " + tabuada[0]
    +"\n1 x " + num + " = " + tabuada[1]
    +"\n2 x " + num + " = " + tabuada[2]
    +"\n3 x " + num + " = " + tabuada[3]
    +"\n4 x " + num + " = " + tabuada[4]
    +"\n5 x " + num + " = " + tabuada[5]
    +"\n6 x " + num + " = " + tabuada[6]
    +"\n7 x " + num + " = " + tabuada[7]
    +"\n8 x " + num + " = " + tabuada[8]
    +"\n9 x " + num + " = " + tabuada[9]
    +"\n10 x " + num + " = " + tabuada[10]
    );