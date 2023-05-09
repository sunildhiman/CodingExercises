using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
           List<int> numbers = Enumerable.Range(1, n).ToList();
            BigInteger sum = numbers.Sum();
            BigInteger sumOfSquares = numbers.Select(x => (long)x * x).Sum();
            BigInteger result =  sum*sum - (numbers.Select(x => (long)x * x).Sum());
            Console.WriteLine(result);
        }
    }
}
