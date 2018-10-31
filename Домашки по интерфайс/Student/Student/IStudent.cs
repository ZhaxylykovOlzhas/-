using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }

        int[] Grades { get; set; }
        int FamilyIncome { get; set; }

        String GetName();
        String GetFullName();
        Double GetAvgGrades();
    }
}
