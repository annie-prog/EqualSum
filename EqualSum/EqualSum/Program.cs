using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int left = 0;
                int right = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j < i) left += numbers[j];
                    else if (j > i) right += numbers[j];
                }
                if (left == right) { sum = i; break; };
            }
            if (sum > -1) Console.WriteLine(sum);
            else Console.WriteLine("no");
        }
    }
}
