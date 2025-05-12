using System;

class Matrix
{
    private int[,] data;
    private int rows;
    private int cols;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        data = new int[rows, cols];
    }

    public int Rows => rows;
    public int Columns => cols;

    public int this[int i, int j]
    {
        get
        {
            if (i >= 0 && i < rows && j >= 0 && j < cols)
                return data[i, j];
            else
                return -1;
        }
        set
        {
            if (i >= 0 && i < rows && j >= 0 && j < cols)
                data[i, j] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Matrix m = new Matrix(3, 4);

        m[1, 2] = 42;

        Console.WriteLine($"Значення в (1,2): {m[1, 2]}");
        Console.WriteLine($"Рядків: {m.Rows}, Стовпців: {m.Columns}");
        Console.WriteLine($"Значення в (5,0): {m[5, 0]}");
    }
}
