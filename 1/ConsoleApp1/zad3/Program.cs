namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            double[] Arr = {180.9,277.08,1.1,1000.1,1.1}
            double sum = 0;
            sum = Arr[0] + Arr[1] + Arr[2] + Arr[3] + Arr[4];
            double sum1 = Math.Round(sum, 2);
            if (sum1 == 1459.47)
            {
                Console.WriteLine($"Yes {sum1}");
            }
            else
            {
                Console.WriteLine($"No {sum1}");
            }*/

            string [] input = Console.ReadLine().Split(",");
            decimal result = 0;
            for (int i=0; i<input.Length; i++)
            {
                result += Decimal.Parse(input[i]);
            }
            Console.WriteLine(result);
        }
    }
}