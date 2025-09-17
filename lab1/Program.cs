using Lab1.Models;
using Lab1.Repositories;

class Program
{
    static void Main()
    {
        string filePath = "students.txt";
        var repo = new StudentRepository(filePath);
        var students = new List<Student>
        {
            new Student { LastName="Іваненко", FirstName="Петро", Course=2, StudentCard="SC123", Gender="M", AverageGrade=5.0, RecordBook="RB001"},
            new Student { LastName="Коваль", FirstName="Анна", Course=2, StudentCard="SC124", Gender="F", AverageGrade=4.8, RecordBook="RB002"},
            new Student { LastName="Сидоренко", FirstName="Олег", Course=2, StudentCard="SC125", Gender="M", AverageGrade=5.0, RecordBook="RB003"}
        };

        repo.Save(students);

        var loaded = repo.Load();
        Console.WriteLine("Усі студенти з файлу:");
        foreach (var s in loaded)
            Console.WriteLine(s);
        var excellent = loaded.FindAll(s => s.Course == 2 && s.Gender == "M" && s.AverageGrade == 5.0);
        Console.WriteLine("\nСтуденти-чоловіки 2-го курсу з відмінними оцінками:");
        foreach (var s in excellent)
            Console.WriteLine(s);
    }
}
