using System;

namespace Task2
{
    class Book
    {
        private string authorName;
        private string authorSurname;
        private string bookName;
        private string code;
        private int year;
        private int pageCount;
        private string genre;

        public Book() { } //конструктор без параметров
        public Book(string a, string b, string c, string d, int e, int f, string g) //конструктор с параметрами
        {
            this.authorName = a; this.authorSurname = b;
            this.bookName = c; this.code = d;
            this.year = e; this.pageCount = f;
            this.genre = g;
        }
        //методы сравнения 2 книг
        public int CompareByAuthor(Book A)
        {
            if (authorName.CompareTo(A.authorName) == 0 && authorSurname.CompareTo(A.authorSurname) == 0)
            {
                Console.WriteLine("Книги '{0}' и '{1}' имеют одинакового автора - {2} {3};", bookName, A.bookName, A.authorName, A.authorSurname);
                return 1;
            }
            else
            {
                Console.WriteLine("Книги '{0}' и {1}' имеют разных авторов", bookName, A.bookName);
                return 0;
            }
        }
        public int CompareByGenre(Book A)
        {
            if (genre.CompareTo(A.genre) == 0)
            {
                Console.WriteLine("Книги '{0}' и '{1}' имеют одинаковый жанр - {2};", bookName, A.bookName, A.genre);
                return 1;
            }
            else
            {
                Console.WriteLine("Книги '{0}' и '{1}' имеют разные жанры.", bookName, A.bookName);
                return 0;
            }
        }
        //поиск книги по коду
        public Book SearchByCode(Book[] A, ref string dezire_code)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if ((String.Equals(A[i].code, dezire_code)))
                    return A[i];
            }
            return null;
        }
        //перегрузка метода ToString
        public override string ToString()
        {
            string info = String.Empty;
            info += ("Название книги: " + bookName + ";\n");
            info += ("Автор: " + authorName + " " + authorSurname + ";\n");
            info += ("Код - " + code + ";\n");
            info += ("Год издания: " + year + ";\n");
            info += ("Количество страниц книги: " + pageCount + ";\n");
            info += ("Жанр книги: " + genre + ";\n");
            return info;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Book[] array = new Book[n];
            array[0] = new Book("Михаил", "Булгаков", "Мастер и Маргарита", "1234", 1987, 645, "Роман");
            array[1] = new Book("Михаил", "Булгаков", "Собачье сердце", "1531", 1967, 341, "Повесть");
            array[2] = new Book("Федор", "Достоевский", "Преступление и наказание", "2532", 1886, 678, "Роман");
            array[3] = new Book("Чак", "Паланик", "Бойцовский клуб", "3431", 1996, 525, "Роман");
            array[4] = new Book("Пауло", "Коэльо", "Алхимик", "4228", 1988, 555, "Роман");

            Console.WriteLine("Книги в наличии:\n");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            Console.WriteLine("ПОИСК книги по коду:");
            int flag1 = 1;
            while (flag1 == 1)
            {
                string dezire_code;
                Console.WriteLine("Введите код для поиска нужной книги:");
                dezire_code = Console.ReadLine();
                Book searchBook = new Book();
                searchBook = searchBook.SearchByCode(array, ref dezire_code);
                if (searchBook != null)
                {
                    Console.WriteLine(searchBook);
                }
                else Console.WriteLine("Книг с указанным кодом ({0}) не найдено.", dezire_code);
                Console.Write("Вы хотите продолжить поиск по коду (Да, Нет): ");
                string answer1 = Console.ReadLine();
                if (String.Equals(answer1, "Нет"))
                    break;
            }
            Console.WriteLine("\nСРАВНЕНИЕ 2 книг параметру:");
            int flag = 1;
            while (flag == 1)
            {
                Console.Write("Введите критерий сравнениия (автор ИЛИ жанр): ");
                string choice = Console.ReadLine();
                Console.WriteLine("Введите номера сравниваемых книг (1-5):");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case "автор":
                        array[a - 1].CompareByAuthor(array[b - 1]);
                        break;
                    case "жанр":
                        array[a - 1].CompareByGenre(array[b - 1]);
                        break;
                    default:
                        Console.WriteLine("ERROR! Недоаустимый вариант");
                        break;
                }
                Console.Write("Вы хотите продолжить сравнение (Да, Нет): ");
                string answer = Console.ReadLine();
                if (String.Equals(answer, "Нет"))
                    break;

            }
            Console.ReadKey();
        }
    }
}
