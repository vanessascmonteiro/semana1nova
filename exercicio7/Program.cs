float nota1, nota2, nota3; 



Console.WriteLine("Digite o nome do aluno");
string aluno = Console.ReadLine();

Console.WriteLine("Digite a quantidade de notas: ");
int quantidadeNotas;
while(!int.TryParse(Console.ReadLine(), out quantidadeNotas)){
    Console.WriteLine("Numero Invalido, por favo entre novamente com a nota");

}

double[] notas = new double[quantidadeNotas];


for(int i=0; i < quantidadeNotas; i++){
    Console.WriteLine("Digite a " + (i +1) + "Nota:");
    notas[i] = double.Parse(Console.ReadLine());

}

double soma = 0;

  
Console.WriteLine($"O Boletim do Aluno: {aluno} ");

for(int i = 0; i < quantidadeNotas; i++)
{
    Console.WriteLine($"N{ (i+1) }: {notas[i]}");
    soma+= notas[i];
}
double media = soma / quantidadeNotas;

string status;
if(media>=6)
{
  status = "aprovado";
   

}
else if(media>=5)
{
    status = "recuperação";

}
else {
   status = "reprovado";    

}

Console.WriteLine($"{aluno} Media: {media} - {status}");

