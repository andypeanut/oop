using System;
class BoxingUnboxingApp
{
    public static void Main()
    {
        int foo = 526;
        object bar = foo; 
        Console.WriteLine(bar);
        try
        {
            double d = (short)bar;

            Console.WriteLine(d);
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine(e + "Error");
        }
    }
}