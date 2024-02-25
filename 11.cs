using System;
using System.Collections.Generic;
using System.Collections;

/* 일반화 메소드
class Exercise10_1
{
    void copyarray(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }
    void copyarray(string[] source, string[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }
    //일반화 메소드 적용
    void copyarray<T>(T[] source, T[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }

    public void Main()
    {
        //일반화 메소드 호출하기
        int[] source = { 1, 2, 3, 4, 5 };
        int[] target = new int[source.Length];
        //자료형을 명시하여 호출한다.
        copyarray<int>(source, target);
    }
    
}*/


/* 일반화 클래스
class Exercise10_2
{
    class Array_Int
    {
        private int[] array;
        public int GetElement(int index)
        { return array[index]; }
    }
    class Array_Double
    {
        private double[] array;
        public double GetElement(int index)
        { return array[index]; }
    }
    //일반화 클래스
    class Array_Generic<T>
    {
        private T[] array;
        public T GetElement(int index)
        { return array[index]; }
    }
    
    public void Main()
    {
        //객체 생성하기
        Array_Generic<int> Intarr = new Array_Generic<int>();
        Array_Generic<double> Doublearr = new Array_Generic<double>();
    }
}*/


/*
public class Exercise10_3
{
    public static void Main()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 5; i++)
            list.Add(i);

        foreach (int element in list)
            Console.Write("{0} ", element);

        Console.WriteLine();

        list.RemoveAt(2);
    }
}*/
