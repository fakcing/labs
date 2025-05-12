using System;

public class MyString
{
    public string Value { get; set; }

    public MyString(string value)
    {
        Value = value;
    }

    public int Length => Value.Length;
public int CountVowels()
{
    int count = 0;
    foreach (char c in Value)
    {
        char lower = char.ToLower(c);
        if ("aeiouаеєєиіїоуюя".Contains(lower))
        {
            count++;
        }
    }
    return count;
}

    public bool ContainsSubstring(string substring)
    {
        return Value.Contains(substring);
    }
}
