 static string pangrams(string s)
    {
        string sonuc = string.Empty;
        string buyukAlfabe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string kucukAlfabe = "abcdefghijklmnopqrstuvwxyz";
        bool pangram = false;

        s = s.ToLower();
        foreach (char harf in kucukAlfabe)
        {
            pangram = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (harf == s[i])
                    break;
                else if(i == s.Length - 1)
                    pangram = false;
            }
            if (!pangram)
                break;
        }

        if (pangram)
            sonuc = "pangram";
        else
            sonuc = "not pangram";

        return sonuc;
    }
