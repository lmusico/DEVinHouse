import Time from "./Time.js";
import Partida from "./Partida.js";

const palmeiras = new Time("Palmeiras", "PAL", 0, 0, 0, 0, 0);
const corinthians = new Time("Corinthians", "COR", 0, 0, 0, 0, 0);
const saopaulo = new Time("São Paulo", "SAO", 0, 0, 0, 0, 0);
const santos = new Time("Santos", "SAN", 0, 0, 0, 0, 0);

// console.log("Numero de jogos do Palmeiras:",palmeiras.numeroDeJogos);

// console.log("Numero de pontos do Palmeiras:", palmeiras.numeroDePontos);

// palmeiras.exibirSituacao();
// teste como mandante
const partida1 = new Partida("PAL",4 , "COR", 0);
const partida2 = new Partida("PAL",1 , "SAO", 1);
const partida3 = new Partida("PAL", 1, "SAN", 2);
// teste como visitante
const partida4 = new Partida("COR",4 , "PAL", 0);
const partida5 = new Partida("SAO",1 , "PAL", 1);
const partida6 = new Partida("SAN", 1, "PAL", 2);



corinthians.computarPartida(partida1);
saopaulo.computarPartida(partida1);

corinthians.computarPartida(partida2);
saopaulo.computarPartida(partida2);
palmeiras.computarPartida(partida1);
palmeiras.computarPartida(partida2);
palmeiras.computarPartida(partida3);
palmeiras.computarPartida(partida4);
palmeiras.computarPartida(partida5);
palmeiras.computarPartida(partida6);


console.log("Numero de jogos do Palmeiras:",palmeiras.numeroDeJogos);

console.log("Numero de pontos do Palmeiras:", palmeiras.numeroDePontos);

palmeiras.exibirSituacao()

corinthians.exibirSituacao()

saopaulo.exibirSituacao()