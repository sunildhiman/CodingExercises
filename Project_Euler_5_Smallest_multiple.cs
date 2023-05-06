internal class Program
{
    private static void Main(string[] args)
    {
        int limit = 50;
        Console.WriteLine("Reps");
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            Console.WriteLine("Number please");
            int n = Convert.ToInt32(Console.ReadLine());
           var primes= GetPrimes(n);
            int smallestmultiple = 1;
            foreach (var prime in primes)
            {
                int biggestPower = GetBiggestPowerOfN(prime, n);
                smallestmultiple = (int)(smallestmultiple * Math.Pow(prime, biggestPower));
            }
            Console.WriteLine(smallestmultiple);
        }
    }

    public static int GetBiggestPowerOfN(int n, int t)
    {
        int power = 1;
        while (Math.Pow(n, power) <= t)
        {
            power ++;
        }
        int largestPower = power -1;
        return largestPower;
    }

    public static List<int> GetPrimes(int limit)
    {
        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }

        return primes;

    }

}
