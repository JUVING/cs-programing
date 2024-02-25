using System;

/*
class calculator
{
    public static int Plus(int a, int b)
    {
        Console.WriteLine("Input : {0}, {1}", a, b);
        int Result = a + b;
        return Result;
    }
    public static void Main()
    {
        int x = calculator.Plus(3, 7);
        int y = calculator.Plus(11, 6);
        Console.WriteLine($"x : {x}   y : {y}");
    }
}

//168pg
class CallbyValueApp
{
    static void Swap(int x,int y)
    {
        int temp = x;x = y;y = temp;
        Console.WriteLine("SWAP = x : {0}, y : {1}", x, y);
    }
    public static void Main()
    {
        int x = 1;int y = 2;
        Console.WriteLine("befor = x : {0}, y : {1}", x, y);
        Swap(x, y);
        Console.WriteLine("after = x : {0}, y : {1}", x, y);
    }
}
class CallbyReferanceApp
{
    static void Swap(ref int x,ref int y)
    {
        int temp = x; x = y; y = temp;
        Console.WriteLine("SWAP = x : {0}, y : {1}", x, y);
    }
    public static void Main()
    {
        int x = 1; int y = 2;
        Console.WriteLine("befor = x : {0}, y : {1}", x, y);
        Swap(ref x, ref y);
        Console.WriteLine("after = x : {0}, y : {1}", x, y);
    }
}
class Integer
{
    public int i;
    public Integer(int i)
    {
        this.i = i;
    }
}
class CallbyObjectReferanceApp
{ 
    static void Swap(Integer x, Integer y)
    {
        int temp = x.i; x.i = y.i; y.i = temp;
        Console.WriteLine("SWAP = x : {0}, y : {1}", x.i, y.i);
    }
    public static void Main()
    {
        Integer x = new Integer(1);
        Integer y = new Integer(2);
        Console.WriteLine("befor = x : {0}, y : {1}", x.i, y.i);
        Swap(x, y);
        Console.WriteLine("after = x : {0}, y : {1}", x.i, y.i);
    }
}*/

/*172pg
class ParamerArrayApp
{
    static void ParameterArray(params object [] obj)
    {
        for (int i = 0; i < obj.Length; i++)
            Console.WriteLine(obj[i]);
    }
    public static void Main()
    {
        ParameterArray(123, "HELLO", true, 'A');
    }
}*/

/*174pg
class MethodOverloadingApp
{
    void somthing()
    {
        Console.WriteLine("somthing() is called.");
    }
    void somthing(int i)
    {
        Console.WriteLine("somthing(int) is called.");
    }
    void somthing(int i, int j)
    {
        Console.WriteLine("somthing(int, int) is called.");
    }
    void somthing(double d)
    {
        Console.WriteLine("somthing(double) is called.");
    }
    public static void Main()
    {
        MethodOverloadingApp obj = new MethodOverloadingApp();
        obj.somthing(10);
        obj.somthing(3.14);
        obj.somthing();
        obj.somthing(100, 63);
    }
}*/