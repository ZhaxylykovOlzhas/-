using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students();
            Console.WriteLine("Введите ваше имя:");
            string name;
            name = Console.ReadLine();
            student.Name = name;
            Console.WriteLine("Введите ваше фамилия:");
            string fullName;
            fullName = Console.ReadLine();
            student.FullName = fullName;
            int numberOfGrades;
            Console.WriteLine("Введите ваше количество оценки:");
            numberOfGrades = Int32.Parse(Console.ReadLine());
            student.Grades = new int[numberOfGrades];
            int grades;
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.WriteLine("Введите ваше " + (i + 1) + "-оценкy:");
                grades = Int32.Parse(Console.ReadLine());
                student.Grades[i] = grades;
            }
            Console.WriteLine("Введите ваше доход на члена семьи:");
            int income;
            income = Int32.Parse(Console.ReadLine());
            student.FamilyIncome = income;

            Console.WriteLine("\n\nBаше имя:");
            Console.WriteLine(student.GetName());
            Console.WriteLine("Bаше фамилия:");
            Console.WriteLine(student.GetFullName());
            Console.WriteLine("Bаше средная оценка:");
            Console.WriteLine(student.GetAvgGrades());

            Console.ReadKey();

        }
    }
}
