using System;
using System.Collections.Generic;
using System.Linq;

public class TextContainer : ITextAnalyzer
{
    private List<MyString> lines = new List<MyString>();

    public void AddLine(MyString line)
    {
        lines.Add(line);
    }

    public void RemoveLine(int index)
    {
        if (index >= 0 && index < lines.Count)
        {
            lines.RemoveAt(index);
        }
    }

    public void Clear()
    {
        lines.Clear();
    }

    public double GetAverageLength()
    {
        if (lines.Count == 0) return 0.0;
        return lines.Average(line => line.Length);
    }

    public double GetVowelPercentage()
    {
        int totalChars = 0, totalVowels = 0;
        foreach (var line in lines)
        {
            totalChars += line.Length;
            totalVowels += line.CountVowels();
        }
        return totalChars == 0 ? 0 : (100.0 * totalVowels / totalChars);
    }

    public void RemoveLinesWithSubstring(string substring)
    {
        lines.RemoveAll(line => line.ContainsSubstring(substring));
    }

    public List<MyString> GetLines()
    {
        return lines;
    }
}
