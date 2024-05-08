using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    internal class task3
    {

// Базовий клас "Працівник"
class Employee : IEnumerable
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string position, double salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Salary: {Salary}");
        }

        // Реалізація методу GetEnumerator для інтерфейсу IEnumerable
        public IEnumerator GetEnumerator()
        {
            yield return this;
        }
    }

    // Похідний клас "Кадри"
    class HR : Employee
    {
        public int YearsOfExperience { get; set; }

        public HR(string name, double salary, int yearsOfExperience)
            : base(name, "HR", salary)
        {
            YearsOfExperience = yearsOfExperience;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Years of Experience: {YearsOfExperience}");
        }
    }

    // Похідний клас "Інженер"
    class Engineer : Employee
    {
        public string Field { get; set; }

        public Engineer(string name, double salary, string field)
            : base(name, "Engineer", salary)
        {
            Field = field;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Field: {Field}");
        }
    }

    // Похідний клас "Адміністрація"
    class Administration : Employee
    {
        public string Department { get; set; }

        public Administration(string name, double salary, string department)
            : base(name, "Administration", salary)
        {
            Department = department;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Department: {Department}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HR hrEmployee = new HR("John Doe", 3500, 5);
            Engineer engineerEmployee = new Engineer("Jane Smith", 4500, "Software Development");
            Administration adminEmployee = new Administration("Alice Johnson", 3000, "Finance");

            // Створення масиву працівників
            Employee[] employees = { hrEmployee, engineerEmployee, adminEmployee };

            // Використання оператора foreach для виведення інформації про працівників
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee Type: {employee.GetType().Name}");
                employee.Show();
                Console.WriteLine();
            }
        }
    }

}
}
