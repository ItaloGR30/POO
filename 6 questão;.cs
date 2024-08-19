Console.WriteLine("Qual é sua idade? ");
int idade = int.Parse(Console.ReadLine());

if(idade>=18){
    Console.WriteLine("Você é maior de idade e está apto a votar e a dirigir");
}else{
    Console.WriteLine("Você é menor de idade");
}