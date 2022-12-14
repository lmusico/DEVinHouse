const obj1 = {
    nome: "Lucas",
    idade: 31,
    profissao: "engenheiro"
};
const obj2 = {
    sobrenome: "Músico",
    nascimento: "17 de janeiro"
};

let concat = (a, b) => {
    let c = {...a, ...b}
    return c;
};

console.log(concat(obj1, obj2));