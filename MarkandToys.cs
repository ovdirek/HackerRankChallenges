using System;

class Solution
{
    static int maximumToys(int[] prices, int k)
    {
        int sonuc = 0;
        int[] siralanmisListe = new int[prices.Length];
        siralanmisListe = bubbleSort(prices);

        for (int i = 0; i < siralanmisListe.Length; i++)
        {
            if (k >= siralanmisListe[i])
            {
                k -= siralanmisListe[i];
                sonuc++;
            }
            else
                break;
        }
        return sonuc;
    }
    static int[] bubbleSort(int[] a)
    {
        int[] siralanacakDizi = new int[a.Length];
        siralanacakDizi = a;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                if (siralanacakDizi[j] > siralanacakDizi[j + 1])
                    siralanacakDizi = swap(siralanacakDizi, j, j + 1);
            }
        }
        return siralanacakDizi;
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
        string[] nk = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);
        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
        int result = maximumToys(prices, k);

        Console.WriteLine(result);
    }
}
