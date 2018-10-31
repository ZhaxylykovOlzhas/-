using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Students : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }
        public int FamilyIncome { get; set; }

        public double GetAvgGrades()
        {
            Double result = 0;

            for (int i = 0; i < Grades.Length; i++)
            {
                result += Grades[i];
            }
            return result / Grades.Length;
        }
        public string GetFullName()
        {
            return FullName;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
