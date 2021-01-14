using System;

class Solution
{
    static long repeatedString(string s, long n)
    {
        long sonuc = 0;
        long tekStringIcindekiAdet = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
                tekStringIcindekiAdet++;
        }
        if (n % s.Length == 0)
        {
            sonuc = tekStringIcindekiAdet * (n / s.Length);
        }
        else
        {
            double bolumSonucOndalik = (double)n / (double)s.Length;
            long bolumSonucTam = Convert.ToInt64(bolumSonucOndalik);
            sonuc = tekStringIcindekiAdet * bolumSonucTam;
            long donguAdedi = n - (bolumSonucTam * s.Length);
            for (int j = 0; j < donguAdedi; j++)
            {
                if (s[j] == 'a')
                {
                    sonuc++;
                }
            }
        }

        return sonuc;
    }

    static void Main(string[] args)
    {
        long result = repeatedString("aba", 10);

        Console.WriteLine(result);
    }
}
