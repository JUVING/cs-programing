using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*72pg
class RelationalOperatorApp
{
    public static void Main()
    {
        int x = 3; int y = 5; int z = 7;
        bool b1, b2;
        b1 = x > y;
        b2 = x >= y && y >= z;
        Console.WriteLine("b1 = " + b1 + " b2 = " + b2);
        b1 = x <= y;
        b2 = x >= y == y >= x;
        Console.WriteLine("b1 = " + b1 + " b2 = " + b2);
    }
}
class LongicalAndApp
{
    public static void Main()
    {
        Console.WriteLine("TRUE AND TRUE = " + (true && true));
        Console.WriteLine("TRUE AND FALSE = " + (true && false));
        Console.WriteLine("FALSE AND TRUE = " + (false && true));
        Console.WriteLine("FALSE AND FALSE = " + (false && false));
    }
}*/


/* 81pg
class ConditionalOperatorApp
{
    public static void Main()
    {
        int a,b,c;
        int m;
        Console.Write("Enter three numbers : ");
        a = Console.Read() - '0';
        b = Console.Read() - '0';
        c = Console.Read() - '0';
        m = (a > b) ? a : b;
        m = (m > c) ? m : c;
        Console.WriteLine("The lagest number : " + m);
    }
}
class printTenItemApp
{
    public static void Main()
    {
        int i, n = 25;
        for(i=1;i<=n;++i)
            Console.Write(i + ((i % 10 == 0 | i == n) ? "\n" : ", "));
    }
}*/


/*79pg
class BitOperatorApp
{
    public static void Main()
    {
        int x = 9, y = 3;
        Console.WriteLine(x + "&" + y + "=" + (x & y));
        Console.WriteLine(x + "   " + y + " = " + (x | y));
        Console.WriteLine(x + "^" + y + " = " + (x ^ y));
        Console.WriteLine("~10 = " + (~10));
    }
}
class ShiftPeratorApp
{
    public static void Main()
    {
        Console.WriteLine(" 10<<2= " + (10 << 2));
        Console.WriteLine(" 10>>2= " + (10 >> 2));
    }
}*/