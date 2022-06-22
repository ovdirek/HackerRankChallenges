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

class Result
{

    public static void plusMinus(List<int> arr)
    {
        
        int pozitifCount = 0, negatifCount = 0, sifirCount = 0;

        foreach (int item in arr)
        {
            if (item > 0)
                pozitifCount++;
            else if (item < 0)
                negatifCount++;
            else
                sifirCount++;
        }

        decimal pozitifOran = (decimal)pozitifCount / arr.Count;
        decimal negatifOran = (decimal)negatifCount / arr.Count;
        decimal sifirOran = (decimal)sifirCount / arr.Count;

        NumberFormatInfo setPrecision = new NumberFormatInfo();
        setPrecision.NumberDecimalDigits = 6;

        Console.WriteLine(pozitifOran.ToString("N", setPrecision));
        Console.WriteLine(negatifOran.ToString("N", setPrecision));
        Console.WriteLine(sifirOran.ToString("N", setPrecision));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int>();

        arr.Add(1);
        arr.Add(1);
        arr.Add(0);
        arr.Add(-1);
        arr.Add(-1);

        Result.plusMinus(arr);
    }
}
