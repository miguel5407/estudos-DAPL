using System;
class Program{
static void acharIMC(){
Console.WriteLine("digite seu peso: ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("digite sua altura: ");
float altura = float.Parse(Console.ReadLine());
double IMC = peso/(altura * altura);
Console.WriteLine($"o seu imc é: {IMC}");
}
static void Main(){
acharIMC();    
}
}