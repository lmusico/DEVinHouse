const nome = "socorrammesubinoonibusemmarrocos";

let verificaPalindromo = (palavra) => {
    let pali;
    for(let x = 0; x<palavra.length; x++){
        if (palavra[x] != palavra[palavra.length-x-1]){
            console.log(`${palavra[x]} é diferente de ${palavra[palavra.length-x-1]}`);
            console.log("Não é palíndromo.");
            pali = false;
            return false

        }else{
            console.log(`${palavra[x]} é igual a ${palavra[palavra.length-x-1]}`);
            pali = true;
        }
    }
    if(pali){
        console.log("É palíndromo!");
        return true
    }
}
if(nome){
    verificaPalindromo(nome);
}

