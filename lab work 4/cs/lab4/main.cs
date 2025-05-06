using System;

public class Line
{
    protected double x1, y1, x2, y2;

    public Line()
    {
        x1 = y1 = x2 = y2 = 0;
    }

    public Line(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public Line(Line other)
    {
        x1 = other.x1;
        y1 = other.y1;
        x2 = other.x2;
        y2 = other.y2;
    }

    public double X1 => x1;
    public double Y1 => y1;
    public double X2 => x2;
    public double Y2 => y2;

    public double Length()
    {
        return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }
}

public class Segment : Line
{
    public Segment(double x1, double y1, double x2, double y2)
        : base(x1, y1, x2, y2) { }

    public double AngleWithOX()
    {
        return Math.Atan2(y2 - y1, x2 - x1) * 180.0 / Math.PI;
    }

    public void PrintData()
    {
        Console.WriteLine($"Start: ({x1}, {y1})");
        Console.WriteLine($"End:   ({x2}, {y2})");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter x1, y1, x2, y2: ");
        string? line = Console.ReadLine();

        if (line != null)
        {
            try
            {
                var input = line.Split();
                if (input.Length < 4)
                {
                    Console.WriteLine("Please enter four numbers separated by spaces.");
                    return;
                }

                double x1 = double.Parse(input[0]);
                double y1 = double.Parse(input[1]);
                double x2 = double.Parse(input[2]);
                double y2 = double.Parse(input[3]);

                Segment s = new Segment(x1, y1, x2, y2);

                s.PrintData();
                Console.WriteLine("Length: " + s.Length());
                Console.WriteLine("Angle with OX: " + s.AngleWithOX() + " degrees");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter valid numbers.");
            }
        }
        else
        {
            Console.WriteLine("No input received.");
        }
    }
}
