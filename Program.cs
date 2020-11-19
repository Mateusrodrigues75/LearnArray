using System;

namespace LearnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");
            string[] nomes = new string[3];
            int[] idades = new int [3];
            
            for (var i = 0; i < 3; i++){
                Console.WriteLine($"Digite o {i + 1}° Nome: ");
                nomes [i] = Console.ReadLine();
                Console.WriteLine("Digite a idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nomes Cadastrados: ");

            for (var i = 0; i < 3; i++){
                Console.WriteLine($"Nome: {nomes[i]}");
                Console.WriteLine($"Idade: {idades[i]}");
            }
        }
    }
}
