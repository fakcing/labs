namespace Lab1.Models;

public class Student
{
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public int Course { get; set; }
    public string StudentCard { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty; // "M" або "F"
    public double AverageGrade { get; set; }
    public string RecordBook { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{LastName} {FirstName}, Курс: {Course}, " +
               $"Студ.квиток: {StudentCard}, Стать: {Gender}, " +
               $"Середній бал: {AverageGrade}, Заліковка: {RecordBook}";
    }
}
