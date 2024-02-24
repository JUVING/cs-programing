using System;
using System.Collections;

/* 배열 66pg
class ArrayTypeApp
{
    public static void Main()
    {
        int[] ia = new int[3]; //ib와 동일한 선언
        int[] ib = { 1, 2, 3 }; //ia와 동일한 선언
        int i;
        for (i = 0; i < ia.Length; i++)
            ia[i] = ib[i];
        for (i = 0; i < ia.Length; i++)
            Console.Write(ia[i] + " ");
        Console.WriteLine();
    }
}

class ArrayofarrayApp
{
    public static void Main()
    {
        int[][] arrayofarray = new int[3][];
        int i, j;
        for (i = 0; i < arrayofarray.Length; i++)
            arrayofarray[i] = new int[i + 3];
        for (i = 0; i < arrayofarray.Length; i++)
            for (j = 0; j < arrayofarray[i].Length; j++)
                arrayofarray[i][j] = i * arrayofarray[i].Length + j;
        for (i = 0; i < arrayofarray.Length; i++)
        {
            for (j = 0; j < arrayofarray[i].Length; j++) 
                Console.Write(" " + arrayofarray[i][j]);
            Console.WriteLine();
        }
    }
}*/


/* System.Array 사용
class ArraySystem
{
    public static void Main()
    {
        int[] array = { 5,4,7,6,1};
        Array.Sort(array);
        foreach (int n in array)
            Console.Write(n + " ");
    }
}

class ArrayApp
{
    public static void Main()
    {
        int[][] arr = new int[3][];
        arr[0]=new int[5]{ 1,4,3,6,8};
        arr[1] = new int[] { 3, 8 };
        arr[2] = new int[] { 1, 4, 8 };

        int[][] arr2 = new int[2][] {
        new int[] { 2, 8, 5, 4 },
        new int[3]{3,9,5} };

    }
}*/

/* 큐

class QueueApp
{
    public static void Main()
    {
        Queue que = new Queue();
        que.Enqueue(1);
        que.Enqueue(2);
        que.Enqueue(3);
        que.Enqueue(4);

        while(que.Count>0)
        { 
            int a = (int)que.Dequeue();
            Console.WriteLine(a);
        }
    }
}*/

/* 스택
class StackApp
{
    public static void Main()
    {
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        int a = (int)stack.Pop();

        Console.WriteLine(a);
    }
}*/

/* 헤쉬테이블
class HashTableApp
{
    public static void Main()
    {
        Hashtable ht = new Hashtable();
        ht["apple"] = "사과";
        ht["banana"] = "바나나";
        ht["melon"] = "멜론";

        Console.WriteLine(ht["banana"]);
        Console.WriteLine(ht["melon"]);
        Console.WriteLine(ht["apple"]);
    }
}*/
