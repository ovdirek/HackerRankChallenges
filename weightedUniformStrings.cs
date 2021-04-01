 static string[] weightedUniformStrings(string s, int[] queries)
    {
        IDictionary<char, int> alfabeAgirlik = new Dictionary<char, int>();
        alfabeAgirlik.Add('a', 1);
        alfabeAgirlik.Add('b', 2);
        alfabeAgirlik.Add('c', 3);
        alfabeAgirlik.Add('d', 4);
        alfabeAgirlik.Add('e', 5);
        alfabeAgirlik.Add('f', 6);
        alfabeAgirlik.Add('g', 7);
        alfabeAgirlik.Add('h', 8);
        alfabeAgirlik.Add('i', 9);
        alfabeAgirlik.Add('j', 10);
        alfabeAgirlik.Add('k', 11);
        alfabeAgirlik.Add('l', 12);
        alfabeAgirlik.Add('m', 13);
        alfabeAgirlik.Add('n', 14);
        alfabeAgirlik.Add('o', 15);
        alfabeAgirlik.Add('p', 16);
        alfabeAgirlik.Add('q', 17);
        alfabeAgirlik.Add('r', 18);
        alfabeAgirlik.Add('s', 19);
        alfabeAgirlik.Add('t', 20);
        alfabeAgirlik.Add('u', 21);
        alfabeAgirlik.Add('v', 22);
        alfabeAgirlik.Add('w', 23);
        alfabeAgirlik.Add('x', 24);
        alfabeAgirlik.Add('y', 25);
        alfabeAgirlik.Add('z', 26);

        List<int> stringAgirlik = new List<int>();
        int count = 1;

        for (int i = 0; i < s.Length; i++)
        {
            if (alfabeAgirlik.ContainsKey(s[i]))
                stringAgirlik.Add(alfabeAgirlik[s[i]] * count);
            
            if (i != s.Length - 1)
            { 
                if (s[i] == s[i+1])
                    count++;
                else
                    count = 1;
            }
        }

        List<String> sonucc = new List<string>();
        foreach (int item in queries)
        {
            if (stringAgirlik.Contains(item))
                sonucc.Add("Yes");
            else
                sonucc.Add("No");
        }

        string[] sonuc = new string[queries.Count()];
        sonuc = sonucc.ToArray();

        return sonuc;
    }
