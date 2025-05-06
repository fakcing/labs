using System;

public abstract class StringBase
{
    protected string value;

    public StringBase(string val)
    {
        value = val;
    }

    public virtual int Length()
    {
        return value.Length;
    }

    public abstract string InsertSymbol();
}

public class UpperCase : StringBase
{
    public UpperCase(string val) : base(val) { }

    public override int Length()
    {
        return value.Length;
    }

    public override string InsertSymbol()
    {
        return string.Join("/", value.ToCharArray());
    }
}

public class LowerCase : StringBase
{
    public LowerCase(string val) : base(val) { }

    public override int Length()
    {
        return value.Length;
    }

    public override string InsertSymbol()
    {
        return string.Join("\\", value.ToCharArray());
    }
}

public static class Processor
{
    public static void ProcessString(StringBase s)
    {
        Console.WriteLine("Length: " + s.Length());
        Console.WriteLine("Modified: " + s.InsertSymbol());
    }
}

class Program
{
    static void Main()
    {
        StringBase upper = new UpperCase("HELLO");
        StringBase lower = new LowerCase("hello");

        Console.WriteLine("UpperCase:");
        Processor.ProcessString(upper);

        Console.WriteLine("\nLowerCase:");
        Processor.ProcessString(lower);
    }
}
