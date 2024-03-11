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
using System.Diagnostics;
using System;

public class BetweenTwoSetsClass
{
    public static void TestBetweenTwoSets()
    {
        List<int> a = new List<int>(1) { 2 };
        List<int> b = new List<int>(3) { 20, 30, 12 };
        int ab = 1;

        List<int> c = new List<int>(1) { 1 };
        List<int> d = new List<int>(1) { 100 };
        int cd = 9;

        List<int> e = new List<int>(3) { 2, 3, 6 };
        List<int> f = new List<int>(2) { 42, 84 };
        int ef = 2;

        List<int> g = new List<int>(1) { 1 };
        List<int> h = new List<int>(3) { 72, 48 };
        int gh = 8;



        getTotalX(a, b, ab);
        getTotalX(c, d, cd);
        getTotalX(e, f, ef);
        getTotalX(g, h, gh);
    }
    static List<int> Sort(List<int> x)
    {
        int[] arr = x.ToArray();

        Array.Sort(arr);
        /*
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
        */
        List<int> s = arr.ToList();

        return s;
    }


    public static void getTotalX(List<int> x, List<int> y, int z)
    {
        List<int> a = Sort(x);
        List<int> b = Sort(y);
        int count;
        int lengthA = a.Count;
        int lengthB = b.Count;
        int lastFacA = a.Count - 1;
        List<int> factors = new List<int>();
        bool isFac;
        string outcome = "Failed";



        Console.Write("a[]: ");
        for (int i = 0; i < lengthA; i++)
        {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine();

        Console.Write("b[]: ");
        for (int i = 0; i < lengthB; i++)
        {
            Console.Write($"{b[i]} ");
        }
        Console.WriteLine();

        for (int i = a[lastFacA]; i <= b[0]; i += a[lastFacA])
        {//loop  2 4 6 8 10 12
            count = 0;
            isFac = true;

            while (count < lengthA)
            {//0a[]  2

                if (i % a[count] != 0)
                {
                    isFac = false;
                    count = lengthA;
                }
                count++;
            }
            if (isFac == true)
            {
                factors.Add(i);
            }
        }


        Console.Write("factors[]: ");
        for (int i = 0; i < factors.Count; i++)
        {
            Console.Write($"{factors[i]} ");
        }
        Console.WriteLine();

        //fac0  2 4 6 8 10 12
        for (int i = 0; i < factors.Count; i++)
        {
            count = 0;
            //Console.WriteLine($"{factors[i]}");

            while (count < lengthB)
            {//b[] 12 20 30
                //Console.Write($"{b[count]} % {factors[i]} = {b[count] % factors[i]}");
                if (b[count] % factors[i] != 0)
                {
                    Console.WriteLine($"{b[count]} % {factors[i]} = {b[count] % factors[i]} - REMOVED");
                    factors.Remove(factors[i]);
                    count = lengthB;
                    i--;
                }
                //Console.WriteLine();
                count++;
            }
            //Console.WriteLine();
        }

        Console.WriteLine($"Expected Output: {z}");
        Console.WriteLine($"Final factors[] count: {factors.Count}");
        for (int i = 0; i < factors.Count; i++)
        {
            Console.Write($"{factors[i]} ");
        }

        if (factors.Count == z)
        {
            outcome = "Success";
        }

        Console.WriteLine($"*****Test {outcome}*****");
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine();
    }
}
