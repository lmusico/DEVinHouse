﻿

Console.WriteLine("Entre com os números:");

List<int> lista = new List<int>() {1, 6, 2, 4, 3, 8, -1, -5, 999};
int menor;
int maior;

for (int i = 0; i < lista.Count; i++)
{   
    for (int j = i; j < lista.Count; j++){
        while(lista[i] > lista[j]){
            menor = lista[j];
            maior = lista[i];
            lista[i] = menor;
            lista[j] = maior;
        }
  
    }

}
foreach (var item in lista)
{
    Console.WriteLine(item);
}