using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Debug.Print(n.ToString());
            long sum = 0;
            long numMultiplesOf3 = (n - 1) / 3;
            long numMultiplesOf5 = (n - 1) / 5;
            long numMultiplesOf15 = (n - 1) / 15;

            sum += (3 + 3 * numMultiplesOf3) * numMultiplesOf3 / 2;
            sum += (5 + 5 * numMultiplesOf5) * numMultiplesOf5 / 2;
            sum -= (15 + 15 * numMultiplesOf15) * numMultiplesOf15 / 2;
            Console.WriteLine(sum);
        }
    }
}
