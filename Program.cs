using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Öğrenci listesi
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 1 },
            new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 2 },
            new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 }
        };

        // Sınıf listesi
        List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Fizik" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };

        // Group Join ile sınıfları ve öğrencileri birleştirme
        var result = from cls in classes
                     join stu in students on cls.ClassId equals stu.ClassId into studentGroup
                     select new
                     {
                         ClassName = cls.ClassName,
                         Students = studentGroup
                     };

        // Sonuçları yazdırma
        foreach (var item in result)
        {
            Console.WriteLine($"Sınıf: {item.ClassName}");

            if (item.Students.Any())
            {
                foreach (var student in item.Students)
                {
                    Console.WriteLine($"\tÖğrenci: {student.StudentName}");
                }
            }
            else
            {
                Console.WriteLine("\tBu sınıfta öğrenci yok.");
            }
            Console.ReadKey();
        }

    }
}
