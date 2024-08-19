int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

if (n1 > n2 && n1 > n3 && n2 > n3){
   Console.WriteLine($"O maior número é: {n1}");
   Console.WriteLine($"O menor númeor é: {n3}");
}else if (n2 > n1 && n2 > n3 && n1 > n3){
   Console.WriteLine($"O maior número é: {n2}");
   Console.WriteLine($"O menor númeor é: {n3}");
}else if(n3 > n1 && n3 > n2 && n1 > n2){
   Console.WriteLine($"O maior número é: {n3}");
   Console.WriteLine($"O menor número é: {n2}");
}else if (n1 > n2 && n1 > n3 && n3 > n2){
   Console.WriteLine($"O maior número é: {n1}");
   Console.WriteLine($"O menor número é: {n2}");
}else if (n2 > n1 && n2 > n3 && n3 > n1){
   Console.WriteLine($"O maior número é: {n2}");
   Console.WriteLine($"O menor número é: {n1}");
}else if (n3 > n1 && n3 > n2 && n2 > n1){
   Console.WriteLine($"O maior número é: {n3}");
   Console.WriteLine($"O menor númeor é: {n1}");
}