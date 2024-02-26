using System;

/* 델리게이트
delegate void DelegateOne();
delegate void DelegateTwo(int i);
class DelegateClass
{
    public void MethodA()
    {
        Console.WriteLine("In the DelegateClass.MethodA...");
    }
    public void MethodB(int i)
    {
        Console.WriteLine("DelegateClass.MethodB, i = " + i);
    }
}
class DeelegateCallApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass();
        DelegateOne d1 = new DelegateOne(obj.MethodA);
        DelegateTwo d2 = new DelegateTwo(obj.MethodB);
        d1();
        d2(10);
    }
}*/


/* 익명 메소드
class Exercise13_2
{
    delegate void Mydelegate(string str);
    public static void Main()
    {
        Mydelegate obj;
        obj = delegate (string s)
        {
            Console.WriteLine($"Mydelegate : {s}");
        };
        obj("안녕하세요");
    }
}*/


/* 멀티캐스트
delegate void Mydelegate();
class Exercise13_3
{
    public void Now()
    {
        Console.WriteLine("TIme : " + DateTime.Now.ToString());
    }
    public static void Today()
    {
        Console.WriteLine("Date : " + DateTime.Today.ToString());
    }
}
class MulticastApp
{
    public static void Main()
    {
        Exercise13_3 obj = new Exercise13_3();
        Mydelegate mcd = new Mydelegate(obj.Now);
        mcd += new Mydelegate(Exercise13_3.Today);
        mcd();
    }
}*/

/* 이벤트
public delegate void MyEventHandler();
class Button
{
    public event MyEventHandler Push;
    public void Onpush()
    {
        if (Push != null)
            Push();
    }
}
class EventHandlerClass
{
    public void Mymethod()
    {
        Console.WriteLine("In the EventHandlerClass.Mymrthod...");
    }
}
class EventHandlerApp
{
    public static void Main()
    {
        Button button = new Button();
        EventHandlerClass obj = new EventHandlerClass();
        button.Push += new MyEventHandler(obj.Mymethod);
        button.Onpush();
    }
}*/

