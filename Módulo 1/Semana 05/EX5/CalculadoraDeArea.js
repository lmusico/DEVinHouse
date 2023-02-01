export default class CalculadoraDeArea{
    constructor(tipo, base, altura){
        this.tipo = tipo;
        this.base = base;
        this.altura = altura;
        this.area = 0;
    }
    calcular(){
        switch (this.tipo) {
            case "quadrado":
            case "retangulo":
                const arear = this.base * this.altura
                return arear;
            case "triangulo":
                const areat = (this.base * this.altura)/2;
                return areat;
            default:
                break;
        }
    }
}