internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(TripleDouble(451999277, 41177722899) == 1);
        Console.WriteLine(TripleDouble(1222345, 12345) == 0);
        Console.WriteLine(TripleDouble(12345, 12345) == 0);
        Console.WriteLine(TripleDouble(666789, 12345667) == 1);
    }
    public static int TripleDouble(long num1, long num2)
    {
        char[] number1 = num1.ToString().ToCharArray();
        char[] number2 = num2.ToString().ToCharArray();
        for (int i = 2; i < number1.Length; i++)
        {
            if (number1[i] == number1[i - 1] && number1[i - 1] == number1[i - 2])
            {
                for (int j = 1; j < number2.Length; j++)
                {
                    if (number2[j] == number2[j - 1] && number2[j] == number1[i])
                    {
                        return 1;
                    }
                }
            }
        }
        return 0;
    }
}
