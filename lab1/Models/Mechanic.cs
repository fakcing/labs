namespace Lab1.Models;

public class Mechanic
{
    public string Name { get; set; } = string.Empty;
    public string Skill { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Механік: {Name}, Вміння: {Skill}";
    }
}
