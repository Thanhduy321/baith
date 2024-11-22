using System;
using System.Collections.Generic;
using System.Linq;
using baith;

public class Program
{
    public static void Main()
    {
        List<Student> students = InitializeStudents();

        DisplayAllStudents(students);
        DisplayStudentsInAgeRange(students, 15, 18);
        DisplayStudentsWithNameStartingWith(students, 'M');
        DisplayTotalAge(students);
        DisplayOldestStudents(students);
        DisplaySortedStudentsByAge(students);
    }

    private static List<Student> InitializeStudents()
    {
        return new List<Student>
        {
            new Student { id = 1, name = "Tran Minh Tu", age = 17 },
            new Student { id = 2, name = "Nguyen Thi Lan", age = 19 },
            new Student { id = 3, name = "Pham Hoang Son", age = 22 },
            new Student { id = 4, name = "Le Quang Vinh", age = 14 },
            new Student { id = 5, name = "Bui Thi Bao", age = 18 }
        };
    }

    private static void DisplayAllStudents(List<Student> students)
    {
        Console.WriteLine("Danh sách toàn bộ học sinh:");
        students.ForEach(student =>
            Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}")
        );
    }

    private static void DisplayStudentsInAgeRange(List<Student> students, int minAge, int maxAge)
    {
        var studentsInAgeRange = students.Where(s => s.age >= minAge && s.age <= maxAge);
        Console.WriteLine($"\nHọc sinh trong độ tuổi từ {minAge} đến {maxAge}:");
        foreach (var student in studentsInAgeRange)
        {
            Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}");
        }
    }

    private static void DisplayStudentsWithNameStartingWith(List<Student> students, char initial)
    {
        var studentsWithM = students.Where(s => s.name.StartsWith(initial.ToString()));
        Console.WriteLine($"\nHọc sinh có tên bắt đầu bằng chữ '{initial}':");
        foreach (var student in studentsWithM)
        {
            Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}");
        }
    }

    private static void DisplayTotalAge(List<Student> students)
    {
        int totalAge = students.Sum(s => s.age);
        Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");
    }

    private static void DisplayOldestStudents(List<Student> students)
    {
        int maxAge = students.Max(s => s.age);
        var oldestStudents = students.Where(s => s.age == maxAge);
        Console.WriteLine("\nHọc sinh có tuổi lớn nhất:");
        foreach (var student in oldestStudents)
        {
            Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}");
        }
    }

    private static void DisplaySortedStudentsByAge(List<Student> students)
    {
        var sortedStudents = students.OrderBy(s => s.age).ToList();
        Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
        sortedStudents.ForEach(student =>
            Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}")
        );
    }
}
