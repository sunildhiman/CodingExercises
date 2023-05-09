using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Reps");
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = Enumerable.Range(1, n).ToList();
            long sum = numbers.Sum();
            BigInteger sumOfSquares = numbers.Select(x => x * x).Sum();
            BigInteger result = sum*sum - sumOfSquares;
            Console.WriteLine(result);

        }
    }

}
