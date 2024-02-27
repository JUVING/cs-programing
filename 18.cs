using System;
using System.IO;

/*BinaryReader
class Exercise18_1
{
    public static void Main()
    {
        BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
        int a = br.ReadInt32();
        string b = br.ReadString();
        uint c = br.ReadUInt32();

        br.Close();
    }
}*/


/*StreamWriter
class Exercise18_2
{
    public static void Main()
    {
        StreamWriter sw = new StreamWriter(new FileStream("a.dat", FileMode.Create));
        sw.Write(int.MaxValue);
        sw.Write("Cood Morning!");
        sw.Write("안녕하세요");

        sw.Close();
    }
}*/


/*
class Exercise18_3
{
    public static void Main()
    {
        StreamReader sr = new StreamReader(new FileStream("a.dat", FileMode.Open));

        while(sr.EndOfStream == false)
        {
            Console.WriteLine(sr.ReadLine());
        }
        sr.Close();
    }
}*/