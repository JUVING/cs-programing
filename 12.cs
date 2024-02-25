using System;


/* 예외 처리
class Exercise11_1
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3 };
        try
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        catch(IndexOutOfRangeException e) //Exception을 사용해도 무관하다.
        {
            Console.WriteLine("예외가 발생했습니다. : {0} ",e.Message);
        }
        Console.WriteLine("종료");
    }
}

//예외 일으키기

class UserErrException : ApplicationException
{
    public UserErrException(string s) : base(s) { }
}
class UserException
{
    public static void Main()
    {
        try
        {
            throw new UserErrException("throw async exception with a message");
        }
        catch(UserErrException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}*/

/* try, catch, throw, finally
class Exercise12_2
{
    static void Dosomething(int arg)
    {
        if (arg < 10)
            Console.WriteLine("arg : {0}", arg);
        else
            throw new Exception("arg가 10보다 큽니다.");
    }
    public static void Main()
    {
        try
        {
            Dosomething(13);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("프로그램 종료...");
        }
    }
}*/

/*
class Exercise12_3
{
    class FilterableException : Exception
    {
        public int ERRORNO { get; set; }
    }
    public static void Main()
    {
        try
        {
            Console.Write(">>> ");
            int num = int.Parse(Console.ReadLine());
            
            if (num < 0 || num > 10)
                throw new FilterableException() { ERRORNO = num };
            else
                Console.WriteLine($"output : {num}");
        }
        catch(FilterableException e) when (e.ERRORNO<0)
        {
            Console.WriteLine("Negatice input is not allowed.");
        }
    }

}*/
