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

class Solution {

    static int alternatingCharacters(string s)
    {
        bool charA;
        if (s[0] == 'A')
            charA = true;
        else
            charA = false;
         
        string sonDizi = s[0].ToString();
        int adet = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if(charA)
            {
                if (s[i] == 'B')
                {
                    adet++;
                    sonDizi += s[i].ToString();
                    charA = false;
                }
            }
            else
            {
                if (s[i] == 'A')
                {
                    charA = true;
                    adet++;
                    sonDizi += s[i].ToString();
                }
            }
        }

        return s.Length - adet;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = alternatingCharacters(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
