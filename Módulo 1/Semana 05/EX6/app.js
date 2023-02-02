import Juros from "./Juros.js";

const calcula = new Juros (10000, 0.07, 24);

const simples = calcula.calcularJurosSimples();

console.log(simples);

const composto = calcula.calcularJurosComposto();

console.log(composto);

const calcula2 = new Juros (10000, 0.15, 10);

const simples2 = calcula.calcularJurosSimples();

console.log(simples);

const composto2 = calcula.calcularJurosComposto();

console.log(composto);