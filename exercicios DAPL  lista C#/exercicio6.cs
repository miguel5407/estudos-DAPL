using System;
class Program{
static void contaPalavras(){
Console.WriteLine("digite um texto: ");
string texto = Console.ReadLine();
string[] palavras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int quantpalavras = palavras.Length;

Console.WriteLine(quantpalavras);
}
static void Main(){
contaPalavras();    
}
}