using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    internal class task2
    {

// Інтерфейс, що успадковує інтерфейси .NET
public interface IPublication : ICloneable, IDisposable
    {
        void PrintInfo();
        bool IsSearchable(string authorLastName);
    }

    // Базовий клас для видань
    public abstract class Publication : IPublication
    {
        public string Title { get; set; }
        public string AuthorLastName { get; set; }

        // Конструктор класу
        protected Publication(string title, string authorLastName)
        {
            Title = title;
            AuthorLastName = authorLastName;
        }

        // Метод для виведення інформації про видання
        public abstract void PrintInfo();

        // Метод для перевірки чи є дане видання шуканим за прізвищем автора
        public bool IsSearchable(string authorLastName)
        {
            return AuthorLastName.Equals(authorLastName, StringComparison.OrdinalIgnoreCase);
        }

        // Методи з інтерфейсів IDisposable та ICloneable
        public void Dispose()
        {
            // Реалізація методу Dispose() 
        }

        public object Clone()
        {
            // Реалізація методу Clone()
            return this.MemberwiseClone();
        }
    }

    // Клас "Книга", що успадковує базовий клас Publication
    public class Book : Publication
    {
        public int Year { get; set; }
        public string Publisher { get; set; }

        // Конструктор класу
        public Book(string title, string authorLastName, int year, string publisher) : base(title, authorLastName)
        {
            Year = year;
            Publisher = publisher;
        }

        // Реалізація методу для виведення інформації про книгу
        public override void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {AuthorLastName}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Publisher: {Publisher}");
        }
    }

    // Клас "Стаття", що успадковує базовий клас Publication
    public class Article : Publication
    {
        public string Journal { get; set; }
        public int IssueNumber { get; set; }

        // Конструктор класу
        public Article(string title, string authorLastName, string journal, int issueNumber) : base(title, authorLastName)
        {
            Journal = journal;
            IssueNumber = issueNumber;
        }

        // Реалізація методу для виведення інформації про статтю
        public override void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {AuthorLastName}");
            Console.WriteLine($"Journal: {Journal}");
            Console.WriteLine($"Issue Number: {IssueNumber}");
        }
    }

    // Клас "Електронний ресурс", що успадковує базовий клас Publication
    public class ElectronicResource : Publication
    {
        public string Link { get; set; }
        public string Annotation { get; set; }

        // Конструктор класу
        public ElectronicResource(string title, string authorLastName, string link, string annotation) : base(title, authorLastName)
        {
            Link = link;
            Annotation = annotation;
        }

        // Реалізація методу для виведення інформації про електронний ресурс
        public override void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {AuthorLastName}");
            Console.WriteLine($"Link: {Link}");
            Console.WriteLine($"Annotation: {Annotation}");
        }
    }

    // Клас, який представляє каталог видань
    public class PublicationCatalog
    {
        private Publication[] _publications;

        // Конструктор класу
        public PublicationCatalog(int size)
        {
            _publications = new Publication[size];
        }

        // Додавання видання в каталог
        public void AddPublication(int index, Publication publication)
        {
            _publications[index] = publication;
        }

        // Виведення повної інформації про всі видання в каталозі
        public void PrintFullCatalog()
        {
            foreach (var publication in _publications)
            {
                publication.PrintInfo();
                Console.WriteLine();
            }
        }

        // Пошук видань за прізвищем автора
        public void SearchByAuthor(string authorLastName)
        {
            Console.WriteLine($"Publications by author {authorLastName}:");
            foreach (var publication in _publications)
            {
                if (publication.IsSearchable(authorLastName))
                {
                    publication.PrintInfo();
                    Console.WriteLine();
                }
            }
        }
    }

}
}
