using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studentName = input[0];
                double grade = Convert.ToDouble(input[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(grade);
                }
                else
                {
                    students[studentName].Add(grade);
                }
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
