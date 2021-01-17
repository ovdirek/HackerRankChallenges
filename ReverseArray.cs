using System;

class Solution
{
    static int[] reverseArray(int[] a)
    {
        int[] sonuc = new int[a.Length - 1];
        sonuc = tersCevir(a);
        return sonuc;
    }

    private static int[] tersCevir(int[] icA)
    {
        int[] cevrilmisDizi = new int[icA.Length];
        cevrilmisDizi = icA;
        int gecici;
        for (int i = 0; i < cevrilmisDizi.Length / 2; i++)
        {
            gecici = cevrilmisDizi[i];
            cevrilmisDizi[i] = cevrilmisDizi[cevrilmisDizi.Length - 1 - i];
            cevrilmisDizi[cevrilmisDizi.Length - 1 - i] = gecici;
        }

        return cevrilmisDizi;
    }

    static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] res = reverseArray(arr);
        Console.WriteLine(string.Join(" ", res));
    }
}
