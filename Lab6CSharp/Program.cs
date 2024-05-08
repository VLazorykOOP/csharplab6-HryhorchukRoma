using System;
using static Lab6CSharp.task1;
using static Lab6CSharp.task2;
using static Lab6CSharp.task3;


    class Program
    {
        static void Main(string[] args)
        {
            // Виклик класів з перших двох файлів
            Book book = new Book("Introduction to Programming", "John Doe", 2020, "Tech Publications");
            Article article = new Article("Data Science Techniques", "Jane Smith", "Data Science Journal", 10);
            ElectronicResource electronicResource = new ElectronicResource("C# Programming Guide", "Alice Johnson", "https://example.com", "An introduction to C# programming");

            // Виклик класів з третього файлу
            HR hrEmployee = new HR("John Doe", 1, 3500, 5);
            Engineer engineerEmployee = new Engineer("Jane Smith", 2, 4500, "Software Development");
            Administration adminEmployee = new Administration("Alice Johnson", 3, 3000, "Finance");

            // Створення масиву працівників
            Employee[] employees = { hrEmployee, engineerEmployee, adminEmployee };

            // Використання оператора foreach для виведення інформації про працівників
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee Type: {employee.GetType().Name}");
                employee.Show();
                Console.WriteLine();
            }

            // Виклик методів виводу для класів з перших двох файлів
            Console.WriteLine("Book Information:");
            book.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Article Information:");
            article.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Electronic Resource Information:");
            electronicResource.PrintInfo();
            Console.WriteLine();
        }
    }
