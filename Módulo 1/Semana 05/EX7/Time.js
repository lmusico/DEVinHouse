export default class Time{
    constructor(nome, sigla, vitorias, derrotas, empates, golsMarcados, golsSofridos){
        this.nome = nome;
        this.sigla = sigla;
        this.vitorias = vitorias;
        this.derrotas = derrotas;
        this.empates = empates;
        this.golsMarcados = golsMarcados;
        this.golsSofridos = golsSofridos;
    }


    computarPartida(partida){
        if(partida.siglaTimeA == this.sigla){
            this.golsMarcados += partida.golsTimeA;
            this.golsSofridos += partida.golsTimeB;
            const saldo = partida.golsTimeA - partida.golsTimeB;
            
            switch (Math.sign(saldo)) {
                case 1:
                    // console.log("Vitória");
                    this.vitorias++;
                    break;
                case 0:
                    // console.log("Empate");
                    this.empates++;
                    break
                case -1:
                    // console.log("Derrota");
                    this.derrotas++;
                default:
                    break;
            }
        }
        if(partida.siglaTimeB == this.sigla){
            this.golsMarcados += partida.golsTimeB;
            this.golsSofridos += partida.golsTimeA;
            const saldo = partida.golsTimeB - partida.golsTimeA;
            
            switch (Math.sign(saldo)) {
                case 1:
                    // console.log("Vitória");
                    this.vitorias++
                    break;
                case 0:
                    // console.log("Empate");
                    this.empates++
                    break
                case -1:
                    // console.log("Derrota");
                    this.derrotas++
                default:
                    break;
            }
        }
    }

    exibirSituacao(){
        console.log ("\n\nNome:", this.nome);
        console.log ("Sigla:", this.sigla);
        console.log ("Vitorias:", this.vitorias);
        console.log ("Derrotas:", this.derrotas);
        console.log ("Empates:", this.empates);
        console.log ("Gols marcados:",this.golsMarcados);
        console.log ("Gols sofridos:",this.golsSofridos);
    }
    
    get numeroDeJogos(){
        return this.vitorias + this.derrotas + this.empates
    }

    get numeroDePontos(){
        return this.vitorias*3 + this.empates
    }
}