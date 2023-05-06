using System.Collections.Generic;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int maxPalindrome = 1;
            bool isproduct = false;
            int f1 = 1, f2 = 1;
            while (!isproduct)
            {
                n--;
                maxPalindrome = NextSmallerPalindrome(n);
                Console.WriteLine(maxPalindrome);
                isproduct = IsProductOfTwoIntegers(maxPalindrome, out f1, out f2);
            }
            Console.WriteLine(maxPalindrome);
        }
    }
    public static int NextSmallerPalindrome(int number)
    {
        
        if (number <= 101101)
        {
            return -1; 
        }
        int result = number - 1;

        int lastDigit = result % 10;
        int firstDigit = result;
        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }
        while (!IsPalindrome(result) || result < 101101)
        {
            result--;
        }
        return result;
    }

    public static bool IsPalindrome(int number)
    {
        if (number < 0 || (number % 10 == 0 && number != 0))
        {
            return false;
        }
        int reversed = 0;
        while (number > reversed)
        {
            reversed = (reversed * 10) + (number % 10);
            number /= 10;
        }
        return number == reversed || number == reversed / 10;
    }
    public static bool IsProductOfTwoIntegers(int n, out int factor1, out int factor2)
    {
        factor1 = 0;
        factor2 = 0;
        var factors = new HashSet<int>();
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                factors.Add(i);
                factors.Add(n / i);
            }
        }

        foreach (int factor in factors.Where(x=>x>99 && x<1000))
        {
            if (factor >= 100 && factor <= 999 && (n / factor > 99 && n / factor < 1000))
            {
                factor1 = factor;
                factor2 = n / factor;
                return true;
            }
        }

        return false;
    }

   
}
