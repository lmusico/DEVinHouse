var idade = window.prompt("Entre com a idade desejada: ");

if (idade <= 15) {
    console.log("Pessoa jovem.");
}
if (idade > 15 && idade <= 64){
    console.log("Pessoa adulta.");
}
if (idade > 64){
    console.log("Pessoa idosa.");
}