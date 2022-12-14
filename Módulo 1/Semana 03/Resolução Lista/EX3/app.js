const lista1 = ["a", "b", "c", "d"];
const lista2 = ["e", "f", "g", "h"];

let concat = (a, b) => {
    let c = [...a, ...b]
    return c;
};

console.log(concat(lista1, lista2));

