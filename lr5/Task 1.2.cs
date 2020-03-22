using System;


namespace Task1__2_
{
    abstract class Person
    {
        protected string surname;
        protected DateTime born_year;
        protected string faculty;

        public abstract void Input();
        public abstract void Show();
        public abstract TimeSpan Age();
    }

    class Applicant : Person
    {
        public override void Input()
        {
            Console.WriteLine("Введите фамилию:");
            surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            born_year = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет:");
            faculty = Console.ReadLine();
        }
        public override TimeSpan Age()
        {
            TimeSpan age = DateTime.Today.Subtract(born_year);
            return age;
        }
        public override void Show()
        {
            Console.WriteLine("Фамилия абитуриета: {0}", surname);
            Console.WriteLine("Дата рождения: {0}, возраст - {1}", born_year.ToShortDateString(), (int)Age().Days / 365);
            Console.WriteLine("Факультет: {0}", faculty);
        }
    }

    class Student : Person
    {
        private int course;

        public override void Input()
        {
            Console.WriteLine("Введите фамилию:");
            surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            born_year = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет:");
            faculty = Console.ReadLine();
            Console.WriteLine("Введите курс обучения:");
            course = int.Parse(Console.ReadLine());
        }
        public override TimeSpan Age()
        {
            TimeSpan age = DateTime.Today.Subtract(born_year);
            return age;
        }
        public override void Show()
        {
            Console.WriteLine("Фамилия студента: {0}", surname);
            Console.WriteLine("Дата рождения: {0}, возраст - {1}", born_year.ToShortDateString(), (int)Age().Days / 365);
            Console.WriteLine("Факультет: {0}, курс обучения - {1}", faculty, course);
        }
    }

    class Teacher : Person
    {
        private string position;
        private int experience;

        public override void Input()
        {
            Console.WriteLine("Введите фамилию:");
            surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            born_year = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет:");
            faculty = Console.ReadLine();
            Console.WriteLine("Введите занимаемую должность:");
            position = Console.ReadLine();
            Console.WriteLine("Введите рабочий стаж:");
            experience = int.Parse(Console.ReadLine());
        }
        public override TimeSpan Age()
        {
            TimeSpan age = DateTime.Today.Subtract(born_year);
            return age;
        }
        public override void Show()
        {
            Console.WriteLine("Фамилия преподавателя: {0}", surname);
            Console.WriteLine("Дата рождения: {0}, возраст - {1}", born_year.ToShortDateString(), (int)Age().Days / 365);
            Console.WriteLine("Факультет: {0}, должность: {1}, рабочий стаж - {2}", faculty, position, experience);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Абитуриент----------------");
            Person applicant = new Applicant();
            applicant.Input();
            applicant.Age();
            applicant.Show();
            Console.WriteLine("----------------Студент----------------");
            Person student = new Student();
            student.Input();
            student.Age();
            student.Show();
            Console.WriteLine("----------------Преподаватель----------------");
            Person teacher = new Teacher();
            teacher.Input();
            teacher.Age();
            teacher.Show();
            Console.ReadKey();
        }
    }
}
