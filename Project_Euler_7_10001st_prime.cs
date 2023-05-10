internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hpow many Reps?");
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            Console.WriteLine("Number please");
            int n = Convert.ToInt32(Console.ReadLine());
            int primenumber = CalculateNthPrime(n);
            Console.WriteLine(primenumber);

        }
    }
    public static int CalculateNthPrime(int n)
    {
        int primeCount = 0;
        int number = 2;
        while (primeCount < n)
        {
            if (IsPrime(number))
                primeCount++;
            if (primeCount == n)
                return number;
            number++;
        }
        return -1; 
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

}
