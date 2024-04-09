namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var euroInput = Console.ReadLine().Split(",");

            var dolarInput = Console.ReadLine().Split(",");

            var euroToln = new decimal[euroInput.Length];
            var dolarToln = new decimal[dolarInput.Length];

            for (int i = 0; i < euroInput.Length; i++)
            {
                euroToln[i] = Decimal.Parse(euroInput[i]) * 1.95m;

            }
            for (int i = 0; i < dolarInput.Length; i++)
            {
                dolarToln[i] = Decimal.Parse(dolarInput[i]) * 1.80m;

            }
            var areEqual = true;

            if (euroToln.Length == dolarToln.Length)
            {
                for (int i = 0; i < euroToln.Length; i++)
                {
                    if (euroToln[i] != dolarToln[i])
                    {
                        areEqual = false;
                        break;
                    }


                }

            }
            else
            {
                areEqual = false;
            }
            Console.WriteLine(areEqual);
        }
    }
}