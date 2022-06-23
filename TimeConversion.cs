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

    public static string timeConversion(string s)
    {
        string sonuc = "";
        int saat = Convert.ToInt32(s.Substring(0, 2));
        if (s[8] == 'P')
        {
            if (saat < 12)
                sonuc = (saat + 12).ToString() + s.Substring(2, 6);
            else
                sonuc = s.Substring(0, 8);
        }
        else
        {
            if (saat >= 12)
            {
                if ((saat - 12).ToString().Length == 1)
                    sonuc = "0" + (saat - 12).ToString() + s.Substring(2, 6);
                else
                    sonuc = (saat - 12).ToString() + s.Substring(2, 6);
            }
            else
                sonuc = s.Substring(0, 8);
        }
        return sonuc;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = "04:59:59AM";

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
    }
}
