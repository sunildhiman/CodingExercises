internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(kangaroo(0, 3, 4, 2) + " |  " + "YES");
        Console.WriteLine(kangaroo(0, 2, 5, 3) + " |  " + "NO");
        Console.WriteLine(kangaroo(21, 6, 47, 3) + " |  " + "NO");
        Console.WriteLine(kangaroo(0, 3, 4, 2) + " |  " + "YES");
        Console.WriteLine(kangaroo(0, 2, 5, 3)+ " |  " + "NO");
        Console.WriteLine(kangaroo(21, 6, 47, 3)+ " |  " + "NO");
        Console.WriteLine(kangaroo(14, 4, 98, 2)+ " |  " + "YES");
        Console.WriteLine(kangaroo(42, 3, 94, 2)+ " |  " + "NO");
        Console.WriteLine(kangaroo(0, 3, 4, 2)+ " |  " + "YES");
        Console.WriteLine(kangaroo(0, 2, 5, 3)+ " |  " + "NO");
        Console.WriteLine(kangaroo(21, 6, 47, 3)+ " |  " + "NO");
        Console.WriteLine(kangaroo(14, 4, 98, 2)+ " |  " + "YES");
        Console.WriteLine(kangaroo(42, 3, 94, 2)+ " |  " + "YES");
        Console.WriteLine(kangaroo(4, 2, 4, 1) + " |  " + "NO");
    }
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {

        if (v1 == v2 && x1!=x2)
        {
            return "NO";
        }
        else if ((x2 - x1) / (v1 - v2) > 0 && ((x2 - x1) % (v1 - v2) == 0))
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }
    public static string kangaroo2(int x1, int v1, int x2, int v2)
    {
        return (v1 == v2 && x1 != x2) ? "NO" : (((x2 - x1) / (v1 - v2) > 0 && ((x2 - x1) % (v1 - v2) == 0)) ? "YES" : "NO");
    }
}
