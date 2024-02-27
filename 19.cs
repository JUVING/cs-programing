using System;
using System.Threading;


/* 스레드 시작하기
class Exercise19_1
{
    static void Dosomthing()
    {
        for(int i=0;i<5;i++)
        {
            Console.WriteLine($"Dosomthing : {i}");
        }
    }
    static void Main()
    {
        Thread t1 = new Thread(new ThreadStart(Dosomthing));
        t1.Start();
        t1.Join();
    }
}*/


/* Abort
class Exercise19_2
{
    static void Dosomthing()
    {
        try 
        { 
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"Dosomthing : {i}");
                Thread.Sleep(10);
            }
        }
        catch(ThreadAbortException e)
        {
            //
        }
        finally
        {
            //
        }
    }
    static void Main()
    {
        Thread t1 = new Thread(new ThreadStart(Dosomthing));
        t1.Start();
        t1.Abort();
        t1.Join();
    }
}*/



