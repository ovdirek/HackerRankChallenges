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
    public static int lonelyinteger(List<int> a)
    {
        int sonuc = 0;
        List<int> b = new List<int>();
        foreach (int item in a)
            b.Add(item);

        foreach (int item in a)
        {
            b.Remove(item);
            if (!b.Contains(item))
            {
                sonuc = item;
                break;
            }
            b.Add(item);
        }
        return sonuc;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = new List<int>();
        a.Add(1);
        a.Add(1);   
        a.Add(2);   

        int result = Result.lonelyinteger(a);

        Console.WriteLine(result.ToString());
    }
}
