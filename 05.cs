using System;

/*132pg
class BreakstApp
{
    public static void Main()
    {
        int n, i;
        double h = 0.0;
        Console.Write("Enter a number = ");
        n = Console.Read() - '0';
        i = 1;
        while(true)
        {
            h = h+1/(double) i;
            if (++i > n) break;
        }
        Console.WriteLine(" n = " + n + ", h = " + h);
    }
}*/


/*123pg
class ForstApp
{
    public static void Main()
    {
        int i, n;
        double h = 0.0;
        Console.Write("Enter a number = ");
        n = Console.Read() - '0';
        for (i = 1; i <= n; ++i)
            h = h + 1 / (double)i;
        Console.WriteLine("n={0}, h={1}", n, h);
    }
}*/

