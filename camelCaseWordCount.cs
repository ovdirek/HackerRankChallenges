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

    // Complete the camelcase function below.
    static int camelcase(string s)
    {
        int adet = 1;

        for (int i = 1; i < s.Length; i++)
        {
            char siradakiKarakter = s[i];
            char kucukHali = siradakiKarakter.ToString().ToLower()[0];

            //Karakteri küçültüp kontrol ettik.
            if (!(kucukHali == siradakiKarakter))
                adet++;
        }

        return adet;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = camelcase(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
