using System;

class Solution
{
    static int[] rotLeft(int[] a, int d)
    {
        int[] sonuc = new int[a.Length];
        sonuc = a;
        for (int i = 0; i < d; i++)
            sonuc = kaydir(sonuc);

        return sonuc;
    }

    private static int[] kaydir(int[] icA)
    {
        int[] kaymisDizi = new int[icA.Length];
        kaymisDizi = icA;
        int gecici = icA[0];
        for (int i = 0; i < kaymisDizi.Length; i++)
        {
            if (i != kaymisDizi.Length - 1)
                kaymisDizi[i] = kaymisDizi[i + 1];
            else
                kaymisDizi[i] = gecici;
        }

        return kaymisDizi;
    }

    static void Main(string[] args)
    {
        string[] nd = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nd[0]);
        int d = Convert.ToInt32(nd[1]);
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        int[] result = rotLeft(a, d);

        Console.WriteLine(string.Join(" ", result));
    }
}
