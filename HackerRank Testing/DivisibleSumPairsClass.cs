using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System;

public class DivisibleSumPairsClass
{
	public static void TestDivisibleSumPairs()
	{
        List<int> a = new List<int>(2) { 8, 10 };
        int a0 = 2;
        int ax = 1;

        List<int> b = new List<int>(20) { 36, 46, 25, 97, 57, 14, 21, 50, 75, 58, 54, 32, 73, 11, 36, 22, 95, 46, 54, 61 };
        int b0 = 7;
        int bx = 16;

        List<int> c = new List<int>(6) { 1, 3, 2, 6, 1, 2 };
        int c0 = 3;
        int cx = 5;

        divisibleSumPairs(ax, a0, a);
        divisibleSumPairs(bx, b0, b);
        divisibleSumPairs(cx, c0, c);

    }

    public static void divisibleSumPairs(int n, int k, List<int> ar)
    {
        int x;
        int pairs = 0;
        int count = 0;
        int[] arr = ar.ToArray();

        Console.Write("{");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($" {arr[i]} ");
        }
        Console.WriteLine("}");
        Console.WriteLine($"Sum of Pair: {k}");

        for (int i = 0; i < ar.Count - 1; i++)
        {
            x = i;
            count = i + 1;
            while (count < ar.Count)
            {
                Console.Write($"{arr[x]} + {arr[count]} % {k} = {(arr[x] + arr[count]) % k} ");
                if ((arr[x] + arr[count]) % k == 0)
                {
                    pairs++;
                    Console.Write($" - {pairs} pair Added");
                }
                count++;
                Console.WriteLine();
            }
        }

        //return pairs;
        Console.WriteLine($" Actual Output: {pairs}\n Expected Answer: {n} ");
        if (n == pairs)
        {
            Console.WriteLine("*****Test Successful*****\n\n");
        }
        else
        {
            Console.WriteLine("-----Test Failed-----\n\n");
        }
    }

}
