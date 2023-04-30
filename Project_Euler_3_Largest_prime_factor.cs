internal class Program
{
    private static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            if (n > 1)
            {
                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    while (n % i == 0 && n !=i)
                    {
                        n =n!=i? n / i:n;
                    }
                }
            }
            else
                n = 1;
            Console.WriteLine(n);
        }
    }
}
