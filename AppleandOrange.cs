using System;

class Solution
{
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int fallenApple = 0;
        int fallenOrange = 0;

        foreach (int apple in apples)
        {
            fallenApple = (a + apple <= t && a + apple >= s) ? fallenApple + 1 : fallenApple;
        }

        foreach (int orange in oranges)
        {
            fallenOrange = (b + orange <= t && b + orange >= s) ? fallenOrange + 1 : fallenOrange;
        }

        Console.WriteLine(fallenApple.ToString());
        Console.WriteLine(fallenOrange.ToString());
    }

    static void Main(string[] args)
    {
        string[] st = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(st[0]);
        int t = Convert.ToInt32(st[1]);
        string[] ab = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(ab[0]);
        int b = Convert.ToInt32(ab[1]);
        string[] mn = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(mn[0]);
        int n = Convert.ToInt32(mn[1]);
        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
