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

    public static int hourglassSum(List<List<int>> arr)
    {
        List<int> list = arr[0];
        List<int> list2 = arr[1];
        List<int> list3 = arr[2];

        int toplam = list[0] + list[0 + 1] + list[0 + 2] + list2[0 + 1] + list3[0] + list3[0 + 1] + list3[0 + 2];
        for (int i = 0; i < arr.Count - 2; i++)
        {
            list = arr[i];
            list2 = arr[i + 1];
            list3 = arr[i + 2];
            for (int j = 0; j < arr.Count - 2; j++)
            {
                int geciciToplam = 0;
                geciciToplam = list[j] + list[j + 1] + list[j + 2] + list2[j + 1] + list3[j] + list3[j + 1] + list3[j + 2];
                if (geciciToplam > toplam)
                    toplam = geciciToplam;
            }
        }

        return toplam;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();
        List<int> arrInner1 = new List<int>();
        List<int> arrInner2= new List<int>();
        List<int> arrInner3 = new List<int>();
        List<int> arrInner4 = new List<int>();
        List<int> arrInner5 = new List<int>();
        List<int> arrInner6 = new List<int>();

        arrInner1.Add(-1);
        arrInner1.Add(-1);
        arrInner1.Add(0);
        arrInner1.Add(-9);
        arrInner1.Add(-2);
        arrInner1.Add(-2);

        arrInner2.Add(-2);
        arrInner2.Add(-1);
        arrInner2.Add(-6);
        arrInner2.Add(-8);
        arrInner2.Add(-2);
        arrInner2.Add(-5);

        arrInner3.Add(-1);
        arrInner3.Add(-1);
        arrInner3.Add(-1);
        arrInner3.Add(-2);
        arrInner3.Add(-3);
        arrInner3.Add(-4);

        arrInner4.Add(-1);
        arrInner4.Add(-9);
        arrInner4.Add(-2);
        arrInner4.Add(-4);
        arrInner4.Add(-4);
        arrInner4.Add(-5);

        arrInner5.Add(-7);
        arrInner5.Add(-3);
        arrInner5.Add(-3);
        arrInner5.Add(-2);
        arrInner5.Add(-9);
        arrInner5.Add(-9);

        arrInner6.Add(-1);
        arrInner6.Add(-3);
        arrInner6.Add(-1);
        arrInner6.Add(-2);
        arrInner6.Add(-4);
        arrInner6.Add(-5);

        arr.Add(arrInner1);
        arr.Add(arrInner2);
        arr.Add(arrInner3);
        arr.Add(arrInner4);
        arr.Add(arrInner5);
        arr.Add(arrInner6);

        int result = Result.hourglassSum(arr);

        Console.WriteLine(result.ToString());
    }
}
