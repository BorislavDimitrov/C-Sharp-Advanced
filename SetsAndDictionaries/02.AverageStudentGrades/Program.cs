using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNum = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < studentsNum; i++)
            {
                List<string> studentInfo = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).ToList();

                if (students.ContainsKey(studentInfo[0]))
                {
                    students[studentInfo[0]].Add(decimal.Parse(studentInfo[1]));
                }
                else
                {
                    List<decimal> grades = new List<decimal>();
                    grades.Add(decimal.Parse(studentInfo[1]));
                    students.Add(studentInfo[0] , grades);
                }
            }

            foreach (var name in students)
            {
                decimal average = name.Value.Average();

                Console.Write($"{name.Key} -> ");

                foreach (var grade in name.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
