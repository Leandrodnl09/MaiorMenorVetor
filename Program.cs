// Exercício curso Nélio Alves.
// Ler quantidade "N" de numeros, armazenar em um vetor e em seguida mostrar o maior e o menor numero, e em cada posição que foi guardado.


int N = int.Parse(Console.ReadLine());
double[] vet = new double[N];
int PosicaoMaior = 1;
int PosicaoMenor = 1;

string[] Num = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(Num[i]);
}
 double Maior = vet[0];
for (int i = 0; i < N; i++)
{
    if (vet[i] > Maior)
    {
        Maior = vet[i];
        PosicaoMaior = i;
    }
}
double Menor = vet[0];   
for (int i = 0; i < N; i++)
{
    if (vet[i] < Menor)
    {
        Menor = vet[i];
        PosicaoMenor = i;
    }
}
Console.WriteLine("O maior número é " + Maior.ToString("F1") + " na posição " + PosicaoMaior);
Console.WriteLine("O menor número é " + Menor.ToString("F1") + " na posição " + PosicaoMenor);