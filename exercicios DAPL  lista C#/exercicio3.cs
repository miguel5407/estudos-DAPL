using System;
class Program{
static void acharPalavra(){
string Palavra = "sonic";
char[] caracteres = Palavra.ToCharArray();
int tentativas = 6;
for(int i = tentativas; i >= 0; i--){
Console.WriteLine("digite um caractere: ");
char caractere = char.Parse(Console.ReadLine());
bool ContemCaractere = Palavra.Contains(caractere);
if(ContemCaractere){
Console.WriteLine("caractere encontrado");
}
else{
Console.WriteLine($"caractere invalido!! restam {tentativas - 1} tentativas");
}
}
}
static void Main(){
acharPalavra();
bool palavraAchada = Palavra;
if(caracteres == palavraAchada){
Console.WriteLine($"palavra encontrada!!! a palavra era {palavra}");
}
else{
Console.WriteLine("palavra não encontrada!!! ");    
}
}
}