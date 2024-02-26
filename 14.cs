using System;


/* 람다식
class Exercise14_1
{
    delegate int calculator(int a, int b);
    public static void Main()
    {
        calculator cal;
        cal = (int a, int b) => a + b;
        Console.WriteLine($"cal = {cal(1,2)}");
    }
}*/


/* 문 형식의 델리게이트
class Exercise14_2
{
    delegate void Dosomthing();
    public static void Main()
    {
        Dosomthing Doso;
        Doso = () =>
        {
            Console.WriteLine("A");
            Console.WriteLine("B");
        };
        Doso();
        
    }
}*/


/* Func, Action 대리자
class Exercise14_3
{
    public static void Main()
    {
        Func<int> func1 = () => 10;
        Console.WriteLine(func1());
        Func<int, int> func2 = (x) => x * 2;
        Console.WriteLine(func2(3));
        Console.WriteLine();
        Action act1 = () => Console.WriteLine("Action()");
        act1();
        Action<double, double> act2 = (x, y) =>
        {
            double Pi = x / y;
            Console.WriteLine($"Action<T1, T2>({x} , {y}) : {Pi}");
        };
        act2(22.0, 7.0);

    }
}*/


