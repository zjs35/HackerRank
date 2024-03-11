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

public class ChocolateClass
{
	public static void TestChocolate()
	{
        List<int> a = new List<int>(5) { 1, 2, 1, 3, 2 };
        int[] a0 = { 3, 2 };

        List<int> b = new List<int>(6) { 1, 1, 1, 1, 1, 1 };
        int[] b0 = { 3, 2 };

        List<int> c = new List<int>(1) { 4 };
        int[] c0 = { 4, 1 };

        birthday(a, a0[0], a0[1], 2);
        birthday(b, b0[0], b0[1], 0);
        birthday(c, c0[0], c0[1], 1);
    }

    public static int equalsDay(int[] p, int d)
    {
        int sum = 0;
        int length = p.Length;

        for (int i = 0; i < length; i++)
        {
            sum += p[i];
        }

        if (sum == d)
        {
            return 1;
        }
        else
        {
            return 0;
        }

    }

    public static void birthday(List<int> s, int d, int m, int e)
    {
        //s[] = {1 2 1 3 2}
        //d = 3
        //m = 2
        int num = 0;
        int count;
        int pnum;
        int[] piece = new int[m];

        Console.Write("Bar[] { ");
        for (int i = 0; i < s.Count; i++)
        {
            Console.Write($" {s[i]}");
        }
        Console.WriteLine(" }");
        Console.WriteLine($"Day: {d}\nMonth: {m}");

        for (int i = 0; i <= s.Count - m; i++)
        { 
            count = i;
            pnum = 0;
            for (int n = count ; n < m + i; n++)
            {
                //Console.WriteLine($"piece[{pnum}] = s[{n}] : {piece[pnum]} = {s[n]}");
                piece[pnum] = s[n];
                pnum++;
                count++;
            }
            Console.Write("[");
            for (int p = 0; p < piece.Length; p++)
            {
                Console.Write($" {piece[p]} ");
            }
            Console.Write("]\n");
            num += equalsDay(piece, d);
        }

        Console.WriteLine($"Expected Answer: {e}\n Actual Output: {num}");
        if (num == e)
        {
            Console.WriteLine("*****Test Successful*****\n\n");
        }
        else
        {
            Console.WriteLine("-----Test Failed-----\n\n");
        }
        //expected 2
        //return num;
        //returned 0
    }
}
