Console.WriteLine("Número do usuário: "); 
int n = int.Parse(Console.ReadLine()); 

if(n>=1){ 
    Console.WriteLine("Positivo");
}else if(n<0){ 
    Console.WriteLine("Negativo"); 
}else{
    Console.WriteLine("Zero"); 
}