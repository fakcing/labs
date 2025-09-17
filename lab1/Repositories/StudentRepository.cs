using Lab1.Models;

namespace Lab1.Repositories;

public class StudentRepository
{
    private readonly string filePath;

    public StudentRepository(string path)
    {
        filePath = path;
    }

    public void Save(List<Student> students)
    {
        using var fs = new FileStream(filePath, FileMode.Create);
        using var writer = new StreamWriter(fs);

        foreach (var s in students)
        {
            string line = $"LastName={s.LastName};FirstName={s.FirstName};Course={s.Course};" +
                          $"StudentCard={s.StudentCard};Gender={s.Gender};" +
                          $"AverageGrade={s.AverageGrade};RecordBook={s.RecordBook}";
            foreach (char c in line)
                writer.Write(c);
            writer.Write('\n');
        }
    }
    public List<Student> Load()
    {
        var students = new List<Student>();
        using var fs = new FileStream(filePath, FileMode.OpenOrCreate);
        using var reader = new StreamReader(fs);

        string line = "";
        int ch;
        while ((ch = reader.Read()) != -1)
        {
            if (ch == '\n')
            {
                if (!string.IsNullOrWhiteSpace(line))
                    students.Add(ParseLine(line));
                line = "";
            }
            else line += (char)ch;
        }
        if (!string.IsNullOrWhiteSpace(line))
            students.Add(ParseLine(line));

        return students;
    }

    private Student ParseLine(string line)
    {
        var s = new Student();
        foreach (var part in line.Split(';'))
        {
            var kv = part.Split('=');
            if (kv.Length != 2) continue;
            switch (kv[0])
            {
                case "LastName": s.LastName = kv[1]; break;
                case "FirstName": s.FirstName = kv[1]; break;
                case "Course": s.Course = int.Parse(kv[1]); break;
                case "StudentCard": s.StudentCard = kv[1]; break;
                case "Gender": s.Gender = kv[1]; break;
                case "AverageGrade": s.AverageGrade = double.Parse(kv[1]); break;
                case "RecordBook": s.RecordBook = kv[1]; break;
            }
        }
        return s;
    }
}
