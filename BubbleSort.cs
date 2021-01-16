
using System;

class Solution
{
    static void countSwaps(int[] a)
    {
        int[] siralanacakDizi = new int[a.Length];
        siralanacakDizi = a;
        int degisimAdedi = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                if (siralanacakDizi[j] > siralanacakDizi[j + 1])
                {
                    siralanacakDizi = swap(siralanacakDizi, j, j + 1);
                    degisimAdedi++;
                }
            }
        }
        Console.WriteLine(string.Concat("Array is sorted in ", degisimAdedi.ToString(), " swaps."));
        Console.WriteLine(string.Concat("First Element: ", siralanacakDizi[0].ToString()));
        Console.WriteLine(string.Concat("Last Element: ", siralanacakDizi[siralanacakDizi.Length - 1].ToString()));
    }

    //Birinci ile ikinciyi yer değiştiriyoruz.
    static int[] swap(int[] degisecekDizi, int birinciIndis, int ikinciIndis)
    {
        int[] sonuc = new int[degisecekDizi.Length];
        sonuc = degisecekDizi;
        int gecici = degisecekDizi[birinciIndis];
        sonuc[birinciIndis] = sonuc[ikinciIndis];
        sonuc[ikinciIndis] = gecici;

        return sonuc;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        countSwaps(a);
    }
}
