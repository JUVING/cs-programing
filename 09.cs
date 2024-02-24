using System;


/* 프로퍼티 (180pg)
class Fraction
{
    private int numerator;
    private int denominator;
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }
    public int Denominator
    {
        get { return denominator; }
        set { denominator = value; }
    }
    public override string ToString()
    {
        return (numerator + "/" + denominator); 
    }
}
class propertyApp
{
    public static void Main()
    {
        Fraction f = new Fraction(); int i;
        f.Numerator = 1;
        i = f.Numerator + 1;
        f.Denominator = i;
        Console.WriteLine(f.ToString());
    }
}



class RwonlypropertyApp
{
    private int readOnlyField = 100;
    private int writeOnlyField;
    public int ReadOnlyProperty
    {
        get { 
            Console.WriteLine("in the readOnlyproperty...");
            return readOnlyField;
        } 
    }
    public int WriteOnlyProperty
    {
        set
        {
            Console.WriteLine("in the Writeonlyproperty...");
            writeOnlyField = value;
        }
    }
    public static void Main()
    {
        RwonlypropertyApp obj = new RwonlypropertyApp();
        obj.WriteOnlyProperty = obj.ReadOnlyProperty;
        Console.WriteLine("value = " + obj.writeOnlyField);
    }
}


class PropertyWithoutFFieldApp
{
    public string Message
    {
        get { return Console.ReadLine(); }
        set { Console.WriteLine(value); }
    }
    public static void Main()
    {
        PropertyWithoutFFieldApp obj = new PropertyWithoutFFieldApp();
        obj.Message = obj.Message;
    }
}*/