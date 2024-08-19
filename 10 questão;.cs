Console.WriteLine("Digite o valor em reais (R$): ");
double n = double.Parse(Console.ReadLine());
double con = n*0.18;
Console.WriteLine($"Em dólar você terá US$ {con:f2}");