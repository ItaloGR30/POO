Console.WriteLine("Quantos nomes você deseja inserir? "); 
int n = int.Parse(Console.ReadLine());
string[] nomes = new string[n];
for (int i = 0; i < n; i++){ 
   Console.WriteLine($"Digite o nome: {i+1}");
   nomes[i] = Console.ReadLine();

}
Array.Sort(nomes);

Console.WriteLine("Lista de nomes em ordem alfabética:"); 
foreach (string nome in nomes)

Console.WriteLine(nome);