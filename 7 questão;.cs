Console.WriteLine("Digite 3 notas:");
float nota1 = float.Parse(Console.ReadLine());
float nota2 = float.Parse(Console.ReadLine());
float nota3 = float.Parse(Console.ReadLine());

float media = CalcularMedia(nota1, nota2, nota3);

Console.WriteLine($"A média é igual a: {media}");

float CalcularMedia(float nota1, float nota2, float nota3){
float media = (nota1 + nota2 + nota3) / 3;
return media;
}