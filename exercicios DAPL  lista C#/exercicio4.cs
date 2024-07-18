using System;
class Program{
static void gerarAleatorio(){
Console.WriteLine("digite a quantidade: ");
int TempoDesejado = int.Parse(Console.ReadLine());
Random numeros = new Random();
int numAleatorio;
for(int i = 0; i < TempoDesejado; i++){
numAleatorio = numeros.Next();
Console.WriteLine($"o numero é : {numAleatorio}");
}
}
static void Main(){
gerarAleatorio();
}
}