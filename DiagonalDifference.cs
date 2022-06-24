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
    public static int diagonalDifference(List<List<int>> arr)
    {
        int result = 0;
        int diagonal1 = 0, diagonal2 = 0;

        for (int i = 0; i < arr[0].Count; i++)
        {
            diagonal1 = diagonal1 + arr[i][i];
            diagonal2 = diagonal2 + arr[i][arr.Count() - 1 - i];
        }

        if (diagonal1 > diagonal2)
            result = diagonal1 - diagonal2;
        else
            result = diagonal2 - diagonal1;
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();
        List<int> arrInner1 = new List<int>();
        List<int> arrInner2 = new List<int>();
        List<int> arrInner3 = new List<int>();

        arrInner1.Add(11);
        arrInner1.Add(2);
        arrInner1.Add(4);

        arrInner2.Add(4);
        arrInner2.Add(5);
        arrInner2.Add(6);

        arrInner3.Add(10);
        arrInner3.Add(8);
        arrInner3.Add(-12);

        arr.Add(arrInner1);
        arr.Add(arrInner2);
        arr.Add(arrInner3);

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result.ToString());
    }
}
