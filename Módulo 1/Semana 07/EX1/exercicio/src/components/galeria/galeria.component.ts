import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-galeria',
  templateUrl: './galeria.component.html',
  styleUrls: ['./galeria.component.css']
})
export class GaleriaComponent {

  public title = "Galeria de Imagens";
  @Input() public fotos: string[] = [];

  public fotoAtual = 0;

  public voltarParaPrimeira () {
    this.fotoAtual = this.primeira()
  }

  public vaiParaUltima() {
    this.fotoAtual = this.ultima();
  } 

  public primeira(){
    return 0;
  }

  public ultima(){
    return this.fotos.length - 1;
  }
  
  public proximaFoto(){
    this.fotoAtual ++;
  }

  public fotoAnterior(){
    this.fotoAtual --;
  }

}
