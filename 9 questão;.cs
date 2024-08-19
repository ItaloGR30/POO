int soma = 0;
int numero = 1; 

while (numero != 0)
{
Console.WriteLine("Digite um número (ou 0 para sair): ");
numero = int.Parse(Console.ReadLine());
soma += numero;
}

Console.WriteLine($"A soma dos números digitados é: {soma}");