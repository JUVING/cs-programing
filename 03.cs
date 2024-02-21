using System;


/*자료형 21pg
class PrimitiveTypeApp
{
    public static void Main()
    {
        bool b; int i = int.MaxValue; uint j = uint.MaxValue;
        double d = double.MaxValue;
        b = (i != 0);
        Console.WriteLine("bool b = " + b);
        Console.WriteLine("int i = " + i);
        Console.WriteLine("unsigned int j" + j);
        Console.WriteLine("double d = " + d);
;    }
}*/



/* 58pg
class IntType
{
    public static void Main()
    {
        int i = 1000000;
        Console.WriteLine(i * i);
        long l = i;
        Console.WriteLine(l * l);
    }
}*/


/*92pg
class boxingunboxingApp
{
    public static void Main()
    {
        int foo = 526;
        object bar = foo; //방식
        Console.WriteLine(bar);
        try
        {
            double d = (short)bar; //명시적(에러 자료형이 다르다) 언박싱 - (int)bar
            Console.WriteLine(d);
        }
        catch(InvalidCastException e)
        {
            Console.WriteLine(e + "ERROR");
        }
    }
}*/


/* 62pg
enum color { red,green,blue};
class EnumTypeApp
{
    public static void Main()
    {
        color c = color.red;
        c++;
        int i = (int)c;
        Console.WriteLine("cardinality of " + c + " +i");
    }
}*/
