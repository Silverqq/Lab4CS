using System;

namespace University
{
    class Student
    {
        public string FullName;
        public string GroupNumber;
        private int Age;

        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {FullName}, Group: {GroupNumber}, Age: {Age}");
        }
    }
}

namespace Library
{
    class Reader
    {
        public string fullName;
        public int LibraryCardNumber;
        public string Faculty;
        private DateTime DateOfBirth;
        public string PhoneNumber;

        public void TakeBook(int count)
        {
            Console.WriteLine($"{fullName} взяла {count} книг.");
        }

        public void TakeBook(params string[] bookNames)
        {
            Console.Write($"{fullName} взяла книги:");
            foreach (var book in bookNames)
            {
                Console.Write($" {book},");
            }
            Console.WriteLine();
        }

        public void ReturnBook(int count)
        {
            Console.WriteLine($"{fullName} вернула {count} книг.");
        }

        public void ReturnBook(params string[] bookNames)
        {
            Console.Write($"{fullName} вернула книги:");
            foreach (var book in bookNames)
            {
                Console.Write($" {book},");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        University.Student[] students = new University.Student[3];
        Library.Reader[] readers = new Library.Reader[3];

        // Initialize student objects
        for (int i = 0; i < 3; i++)
        {
            students[i] = new University.Student();
            students[i].FullName = "Илья Киселев";
            students[i].GroupNumber = "25ит18";
            students[i].DisplayInfo();
        }

        // Initialize reader objects
        for (int i = 0; i < 3; i++)
        {
            readers[i] = new Library.Reader();
            readers[i].fullName = "Юлия Романова";
            readers[i].LibraryCardNumber = 12345 + i;
            readers[i].Faculty = "Наука";
            readers[i].TakeBook(3);
            readers[i].TakeBook("Приключение", "Детектив", "Энциклопедия");
            readers[i].ReturnBook(3);
            readers[i].ReturnBook("Приключение", "Детектив", "Энциклопедия");
        }
    }
}