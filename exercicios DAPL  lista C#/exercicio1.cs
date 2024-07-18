using System;
class Program{
static void celsiusParaFahren(){
Console.WriteLine("digite a temperatura em celsius");
int tempInicial = int.Parse(Console.ReadLine());
int tempFinal = ((tempInicial * 9)/5) + 32;
Console.WriteLine($"a temperatura em fahrenheit é {tempFinal}");
}
static void fahrenParaCelsius(){
Console.WriteLine("digite a temperatura em fahrenheit");
int tempInicial = int.Parse(Console.ReadLine());
int tempFinal = (tempInicial - 32) * 5/9;
Console.WriteLine($"a temperatura em celsius é {tempFinal}");
}
static void Main(){
celsiusParaFahren();
fahrenParaCelsius();
}
}