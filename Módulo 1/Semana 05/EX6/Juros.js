export default class Juros{
    constructor(capitalInicial, taxaAplciada, tempo){
        this.c = capitalInicial;
        this.i = taxaAplciada;
        this.t = tempo;
        this.j = 0;
        this.m = 0;
    }
    calcularJurosSimples(){
        this.j = this.c * this.i * this.t;
        return this.j;
    }

    calcularJurosComposto(){
        this.m = this.c * (1 + this.i) ** this.t
        return this.m;
    }
}