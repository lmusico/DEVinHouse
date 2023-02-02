import Time from "./Time.js";
import Partida from "./Partida.js";

const palmeiras = new Time("Palmeiras", "PAL", 0, 0, 0, 0, 0);
const corinthians = new Time("Corinthians", "COR", 0, 0, 0, 0, 0);
const saopaulo = new Time("São Paulo", "SAO", 0, 0, 0, 0, 0);
const santos = new Time("Santos", "SAN", 0, 0, 0, 0, 0);

// console.log("Numero de jogos do Palmeiras:",palmeiras.numeroDeJogos);

// console.log("Numero de pontos do Palmeiras:", palmeiras.numeroDePontos);

// palmeiras.exibirSituacao();

const partida1 = new Partida("PAL",4 , "COR", 0);

// console.log(partida1)

const partida2 = new Partida("SAO",1 , "PAL", 2);
const partida3 = new Partida("SAN", 1, "PAL", 1);

palmeiras.computarPartida(partida1);
corinthians.computarPartida(partida1);
saopaulo.computarPartida(partida1);

palmeiras.computarPartida(partida2);
corinthians.computarPartida(partida2);
saopaulo.computarPartida(partida2);

palmeiras.computarPartida(partida3);


console.log("Numero de jogos do Palmeiras:",palmeiras.numeroDeJogos);

console.log("Numero de pontos do Palmeiras:", palmeiras.numeroDePontos);

palmeiras.exibirSituacao()

corinthians.exibirSituacao()

saopaulo.exibirSituacao()