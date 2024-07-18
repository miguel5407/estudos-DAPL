using System;
class Program{
static void Cadastro(){
Console.WriteLine("digite a quantidade de estudantes");
int quantAluno = int.Parse(Console.ReadLine());
for(int i = 0; i < quantAluno; i++){
Console.WriteLine($"digite o nome do aluno {i + 1}");
string nomeAluno = Console.ReadLine();
Console.WriteLine($"digite a idade do aluno {i + 1}");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine($"digite a nota do aluno {i + 1}");
int nota = int.Parse(Console.ReadLine());
Console.WriteLine($"as informações são {nomeAluno}, {idade}, {nota}");
}
}
static void Main(){
Cadastro();    
}
}