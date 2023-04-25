internal class Program
{
    private static void Main(string[] args)
    {
        countApplesAndOranges(7, 11, 5, 15, new List<int>() { -2, 2, 1 }, new List<int>() { 5, -6 }); // 1 1
    }
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int applecount = apples.Where(i => a + i >= s && a + i <= t).Count();
        int orangecount = oranges.Where(i => b + i >= s && b + i <= t).Count(); 
        Console.WriteLine(applecount);
        Console.WriteLine(orangecount);
    }
}
