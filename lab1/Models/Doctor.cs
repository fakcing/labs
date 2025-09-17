namespace Lab1.Models;

public class Doctor
{
    public string Name { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Лікар: {Name}, Спеціалізація: {Specialty}";
    }
}
