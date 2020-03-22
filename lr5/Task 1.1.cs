using System;


namespace Task1__1_
{
    abstract class Figure
    {
        protected double P;
        protected double S;

        public abstract void Input();
        public abstract void Show();
        public abstract double Perimeter();
        public abstract double Square();
    }

    class Rectangle : Figure
    {
        private double a;
        private double b;
        public override void Input()
        {
            Console.WriteLine("Введите стороны a и b прямоугольника:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
        }
        public override double Perimeter()
        {
            return P = 2 * (a + b);
        }
        public override double Square()
        {
            return S = a * b;
        }
        public override void Show()
        {
            Console.WriteLine("Стороны прямоугольника равны {0} и {1}, перимметр = {2}, площадь = {3}", a, b, P, S);
        }
    }

    class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        public override void Input()
        {
            Console.WriteLine("Введите стороны a, b и c треугольника:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
        }
        public override double Perimeter()
        {
            return P = a + b + c;
        }
        public override double Square()
        {
            double p = (a + b + c) / 2;
            return S = Math.Sqrt(p + (p - a) * (p - b) * (p - c));
        }
        public override void Show()
        {
            Console.WriteLine("Стороны треугольника равны {0}, {1}, {2}, перимметр = {3}, площадь = {4}", a, b, c, P, S);
        }
    }

    class Circle : Figure
    {
        private double R;
        public override void Input()
        {
            Console.WriteLine("Введите радиус круга R:");
            R = double.Parse(Console.ReadLine());
        }
        public override double Perimeter()
        {
            return P = 2 * Math.PI * R;
        }
        public override double Square()
        {
            return S = Math.PI * Math.Pow(R, 2);
        }
        public override void Show()
        {
            Console.WriteLine("Радиус круга равен {0}, перимметр = {1}, площадь = {2}", R, P, S);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доступные типы фигур:");
            Console.WriteLine("1 - прямоугольник;\n2 - треугольник;\n3 - круг;");

            int n;
            Console.WriteLine("\nВведите количество фигур n:");
            n = int.Parse(Console.ReadLine());
            Figure[] Object = new Figure[n];

            int type;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nВыберете тип фигуры:");
                type = int.Parse(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        Object[i] = new Rectangle();
                        Object[i].Input();
                        Object[i].Perimeter();
                        Object[i].Square();
                        Object[i].Show();
                        break;
                    case 2:
                        Object[i] = new Triangle();
                        Object[i].Input();
                        Object[i].Perimeter();
                        Object[i].Square();
                        Object[i].Show();
                        break;
                    case 3:
                        Object[i] = new Circle();
                        Object[i].Input();
                        Object[i].Perimeter();
                        Object[i].Square();
                        Object[i].Show();
                        break;
                    default:
                        Console.WriteLine("ERROR! Недопустимый вариант.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
