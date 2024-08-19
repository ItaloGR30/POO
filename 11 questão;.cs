Console.WriteLine("Digite um número para calcular o fatorial:");
int n = int.Parse(Console.ReadLine());

int resultado = CalcularFatorial(n);

Console.WriteLine($"{n}! = {resultado}");

int CalcularFatorial(int n){
int fatorial = 1;

for (int i = n; i > 0; i--){
fatorial *= i;
}

return fatorial;
}