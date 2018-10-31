using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            bool isPars;
            string firstName, lastName;
            int salary;
            DateTime workStartDate;
            Person clerk = new Person();
            Console.WriteLine("Введите количество сотрудников:");
            isPars = int.TryParse(Console.ReadLine(), out size);
                List<Person> managers = new List<Person>();
                List<Person> clerks = new List<Person>();
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("\nВведите фамилию сотрудника:");
                    lastName = Console.ReadLine();

                    Console.WriteLine("\nВведите имя сотрудника:");
                    firstName = Console.ReadLine();

                    Console.WriteLine("\nВведите зарплату сотрудника:");
                    isPars = int.TryParse(Console.ReadLine(), out salary);

                    Console.WriteLine("\nВведите дату трудоустройства сотрудника:");
                    isPars = DateTime.TryParse(Console.ReadLine(), out workStartDate);
                    clerk.FirstName = firstName;
                    clerk.LastName = lastName;
                    clerk.Salary = salary;
                    clerk.WorkStartDate = workStartDate;
                    clerks.Add(clerk);        
                Person boss = new Person();
                Console.WriteLine("\nВведите фамилию босс:");
                lastName = Console.ReadLine();
                Console.WriteLine("\nВведите имя босс:");
                firstName = Console.ReadLine();
                Console.WriteLine("\nВведите зарплату босс:");
                isPars = int.TryParse(Console.ReadLine(), out salary);
                Console.WriteLine("\nВведите дату трудоустройства босс:");
                isPars = DateTime.TryParse(Console.ReadLine(), out workStartDate);
                boss.FirstName = firstName;
                boss.LastName = lastName;
                boss.Salary = salary;
                boss.WorkStartDate = workStartDate;

                Console.WriteLine("\nВывод всего персонала.");
                ShowAllStaff(managers, clerks, boss);

                Console.WriteLine("\nВывод всех мэнэджеров.");
                FindManager(managers, clerks);

                Console.WriteLine("\nВывод всего персонала после прихода босса.");
                FindAfterBoss(clerks, boss);

                Console.ReadLine();
            }
        }
        static void ShowAllStaff(List<Person> managers, List<Person> clerks, Person boss)
        {
            for (int i = 0; i < clerks.Count; i++)
            {
                Console.WriteLine(i + ".");
                Console.WriteLine("Имя сотрудника:" + clerks[i].FirstName);
                Console.WriteLine("Фамилия сотрудника:" + clerks[i].LastName);
                Console.WriteLine("Зарплата:" + clerks[i].Salary);
                Console.WriteLine("Дата трудоустройства:" + clerks[i].WorkStartDate + "\n");
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Имя босса:" + boss.FirstName);
            Console.WriteLine("Фамилия босса:" + boss.LastName);
            Console.WriteLine("Зарплата:" + boss.Salary);
            Console.WriteLine("Дата трудоустройства:" + boss.WorkStartDate + "\n");
        }
        static void FindManager(List<Person> managers, List<Person> clerks)
        {
            Person manager = new Person();

            int avgSalary = 0, salarySum = 0;

            for (int i = 0; i < clerks.Count; i++)
            {
                salarySum += clerks[i].Salary;
            }
            avgSalary = salarySum / clerks.Count;
            for (int i = 0; i < clerks.Count; i++)
            {
                if (avgSalary < clerks[i].Salary)
                {
                    manager.FirstName = clerks[i].FirstName;
                    manager.LastName = clerks[i].LastName;
                    manager.Salary = clerks[i].Salary;
                    manager.WorkStartDate = clerks[i].WorkStartDate;

                    managers.Add(manager);
                }
            }
            var sortedUsers = managers.OrderBy(u => u.LastName);
            Console.WriteLine("\n\n\n");
            foreach (Person sortedManager in sortedUsers)
            {
                Console.WriteLine("Имя мэнеджера:" + sortedManager.FirstName);
                Console.WriteLine("Фамилия мэнеджера:" + sortedManager.LastName);
                Console.WriteLine("Зарплата:" + sortedManager.Salary);
                Console.WriteLine("Дата трудоустройства:" + sortedManager.WorkStartDate + "\n");
            }
        }
        static void FindAfterBoss(List<Person> clerks, Person boss)
        {
            List<Person> stuffAfter = new List<Person>();
            Person clerk = new Person();
            for (int i = 0; i < clerks.Count; i++)
            {
                if (boss.WorkStartDate < clerks[i].WorkStartDate)
                {
                    clerk.FirstName = clerks[i].FirstName;
                    clerk.LastName = clerks[i].LastName;
                    clerk.Salary = clerks[i].Salary;
                    clerk.WorkStartDate = clerks[i].WorkStartDate;

                    stuffAfter.Add(clerk);
                }
            }
            var sortedUsers = stuffAfter.OrderBy(u => u.LastName);
            Console.WriteLine("\n\n\n");
            foreach (Person sortedClerk in sortedUsers)
            {
                Console.WriteLine("Имя сотрудника:" + sortedClerk.FirstName);
                Console.WriteLine("Фамилия сотрудника:" + sortedClerk.LastName);
                Console.WriteLine("Зарплата:" + sortedClerk.Salary);
                Console.WriteLine("Дата трудоустройства:" + sortedClerk.WorkStartDate + "\n");
            }
        }
    }
}
