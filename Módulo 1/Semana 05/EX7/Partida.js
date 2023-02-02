export default class Partida{
    constructor(siglaTimeA, golsTimeA, siglaTimeB, golsTimeB){
        this.siglaTimeA = siglaTimeA;
        this.siglaTimeB = siglaTimeB;
        this.golsTimeA = golsTimeA;
        this.golsTimeB = golsTimeB;
        return {
            siglaTimeA: this.siglaTimeA,
            siglaTimeB: this.siglaTimeB,
            golsTimeA: this.golsTimeA,
            golsTimeB: this.golsTimeB
        }
    }
}