Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());

if (n <= 0){
Console.WriteLine("Digite um número positivo");
}

int primeiro = 0;
int segundo = 1;

Console.WriteLine("Sequência de Fibonacci:");

while (primeiro <= n)
{
Console.Write(primeiro + " ");
int proximo = primeiro + segundo;
primeiro = segundo;
segundo = proximo;
}