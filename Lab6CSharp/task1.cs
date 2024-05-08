using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    internal class task1
    {
        // Базовий клас
        public class Employee
        {
            public string Name { get; set; }
            public int EmployeeId { get; set; }
            public double Salary { get; set; }

            // Конструктор класу
            public Employee(string name, int id, double salary)
            {
                Name = name;
                EmployeeId = id;
                Salary = salary;
            }

            // Метод для виведення даних про об'єкт класу
            public virtual void Show()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Employee ID: {EmployeeId}");
                Console.WriteLine($"Salary: {Salary}");
            }
        }

        // Клас "Робітник", що успадковує базовий клас Employee
        public class Worker : Employee
        {
            public string WorkType { get; set; }

            // Конструктор класу
            public Worker(string name, int id, double salary, string workType) : base(name, id, salary)
            {
                WorkType = workType;
            }

            // Перевизначений метод для виведення даних про об'єкт класу
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Work Type: {WorkType}");
            }
        }

        // Клас "Кадри", що успадковує базовий клас Employee
        public class HR : Employee
        {
            public int NumberOfEmployeesManaged { get; set; }

            // Конструктор класу
            public HR(string name, int id, double salary, int numberOfEmployeesManaged) : base(name, id, salary)
            {
                NumberOfEmployeesManaged = numberOfEmployeesManaged;
            }

            // Перевизначений метод для виведення даних про об'єкт класу
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Number of Employees Managed: {NumberOfEmployeesManaged}");
            }
        }

        // Клас "Інженер", що успадковує базовий клас Employee
        public class Engineer : Employee
        {
            public string EngineeringField { get; set; }

            // Конструктор класу
            public Engineer(string name, int id, double salary, string engineeringField) : base(name, id, salary)
            {
                EngineeringField = engineeringField;
            }

            // Перевизначений метод для виведення даних про об'єкт класу
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Engineering Field: {EngineeringField}");
            }
        }

        // Клас "Адміністрація", що успадковує базовий клас Employee
        public class Administration : Employee
        {
            public string Department { get; set; }

            // Конструктор класу
            public Administration(string name, int id, double salary, string department) : base(name, id, salary)
            {
                Department = department;
            }

            // Перевизначений метод для виведення даних про об'єкт класу
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Department: {Department}");
            }
        }

    }
}
