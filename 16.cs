#define CSHARP
using System;
using System.Diagnostics;

/* 애트리뷰트
class Exercise16_1
{
    [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
    public void OldMethod()
    {
        Console.WriteLine("Im old");
    }
    public void NewMethod()
    {
        Console.WriteLine("In new");
    }
}


class conditionalAttrApp
{
    [Conditional("CSHARP")]
    public static void CsharpMethod()
    {
        Console.WriteLine("In the Csharp Method...");
    }
    [Conditional("java")]
    public static void JavaMethod()
    {
        Console.WriteLine("In the Java Method...");
    }
    public static void Main()
    {
        conditionalAttrApp.CsharpMethod();
        conditionalAttrApp.JavaMethod();
    }
}*/