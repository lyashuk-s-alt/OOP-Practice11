using System;

namespace Rozumatic_OOP_Practice11
{
    // ==========================================================================
    // БАЗОВИЙ КЛАС: PERSON (З конструктором з параметрами)
    // ==========================================================================
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Конструктор базового класу з параметрами
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Базовий метод виведення інформації
        public virtual void PrintInfo()
        {
            Console.Write($"Ім'я: {Name,-10} | Вік: {Age} р.");
        }
    }

    // ==========================================================================
    // ПОХІДНИЙ КЛАС: STUDENT (Загальне + Домашнє завдання)
    // Передає дані в base() та перевизначає метод із викликом base.PrintInfo()
    // ==========================================================================
    public class Student : Person
    {
        public string Faculty { get; set; }
        public int Course { get; set; }

        // ЗАГАЛЬНЕ ЗАВДАННЯ: Передача імені та віку до конструктора батьківського класу через : base(...)
        public Student(string name, int age, string faculty, int course) 
            : base(name, age)
        {
            Faculty = faculty;
            Course = course;
        }

        // ДОМАШНЄ ЗАВДАННЯ: Перевизначення методу виведення інформації з викликом базової версії
        public override void PrintInfo()
        {
            // Виклик базової версії методу для виведення імені та віку
            base.PrintInfo(); 
            
            // Додавання специфічної інформації студента в тому ж рядку
            Console.WriteLine($" | Факультет: {Faculty,-5} | Курс: {Course}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("  РОЗУМАТИК // ПРАКТИЧНЕ ЗАНЯТТЯ №11: КЛЮЧОВЕ СЛОВО BASE");
            Console.WriteLine("==========================================================================");

            // Створення об'єкта базового класу
            Console.WriteLine("\n--- Об'єкт базового класу Person ---");
            Person person = new Person("Андрій", 45);
            person.PrintInfo();
            Console.WriteLine(); // перенос рядка

            // Створення об'єкта дочірнього класу
            Console.WriteLine("\n--- Об'єкт похідного класу Student ---");
            Student student = new Student("Дмитро", 20, "ФІКТ", 3);
            
            // Виклик перевизначеного методу
            student.PrintInfo();

            Console.WriteLine("\n✅ Практичне заняття №11 успішно виконано!");
        }
    }
}
