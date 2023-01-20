using System;
namespace inlämnningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            int[] heltal = new int[antal];
            for(int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv in ett heltal");
                heltal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Här är hetalen du skrev in");
            for(int i = 0; i < antal; i++)
            {
                Console.WriteLine(heltal[i]);
            }
        }
    }
}