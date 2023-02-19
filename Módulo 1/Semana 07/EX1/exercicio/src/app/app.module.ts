import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { GaleriaComponent } from 'src/components/galeria/galeria.component';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    GaleriaComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
