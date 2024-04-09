using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 zadacha
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            
        }
    }
}