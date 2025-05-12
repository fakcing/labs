using System;

class Program
{
    static void Main()
    {
        TextContainer text = new TextContainer();

        text.AddLine(new MyString("Привіт, світ"));
        text.AddLine(new MyString("C++ потужний"));
        text.AddLine(new MyString("Це тестовий рядок"));

        Console.WriteLine("Рядки в тексті:");
        foreach (var line in text.GetLines())
        {
            Console.WriteLine(line.Value);
        }

        Console.WriteLine("\nСередня довжина рядка: " + text.GetAverageLength());
        Console.WriteLine("Відсоток голосних: " + text.GetVowelPercentage() + "%");

        text.RemoveLinesWithSubstring("тест");

        Console.WriteLine("\nПісля видалення рядків, що містять 'тест':");
        foreach (var line in text.GetLines())
        {
            Console.WriteLine(line.Value);
        }
    }
}
