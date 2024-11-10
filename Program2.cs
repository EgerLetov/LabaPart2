using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Разработать класс с тремя вещественными полями.
//Создать конструктор копирования.
//Разработать метод, приводящий поля к целому типу.
//Перегрузить метод ToString() для
//формирования строки из полей класса.
//Реализовать дочерний класс (его содержание предложить
//самостоятельно и описать в решении:
//какой содержательный смысл имеют поля; реализовать
//конструкторы; предложить и реализовать 2-3 метода). Протестировать все конструкторы и
//другие методы базового и дочернего классов.
namespace Laba2_2and3
{
    public class Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Вычисляет расстояние между двумя точками
        public double Dist(Point P)
        {
            return Math.Sqrt(Math.Pow(this.x - P.x, 2) + Math.Pow(this.y - P.y, 2));
        }

        // Переопределенный метод ToString()
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // Явное преобразование в double
        public static Point operator --(Point op)
        {
            // Создайте новый объект с измененными координатами
            return new Point ( op.x - 1, op.y - 1 );
        }

        // Оператор унарного минуса
        public static Point operator -(Point op)
        {
            // Создайте новый объект с измененными координатами
            return new Point (op.y, op.x );
        }

        public static explicit operator double(Point c)
        {
            return c.y;
        }

        // Неявное преобразование в int 
        public static implicit operator int(Point c)
        {
            return Convert.ToInt32(c.x);
        }


        // Бинарный оператор вычитания для Point и long
        public static Point operator -(Point p, long value)
        {
            return new Point (p.x - value, p.y );
        }

        public static Point operator -(int value, Point p)
        {
            return new Point (p.x, p.y - value );
        }
        public static double operator -(Point p1, Point p2)
        {
            // Вычисляем расстояние по формуле
            double distance = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
            return distance;
        }
    }



    internal class Program
    {
        public double DurDub(String s)
        {
            while (!double.TryParse(s, out double x))
            {
                Console.WriteLine("Вы ввели не число.");
                Console.WriteLine("Введите число:");
                s = Console.ReadLine();

            }
            return Convert.ToDouble(s);
        }
        public static void Main()
        {
            Program program = new Program();
            Console.WriteLine("Введите x первой точки:");
            double a = program.DurDub(Console.ReadLine());
            Console.WriteLine("Введите y первой точки:");
            double b = program.DurDub(Console.ReadLine());
            Point P1 = new Point(a, b);
            Console.WriteLine("Введите x второй точки:");
            a = program.DurDub(Console.ReadLine());
            Console.WriteLine("Введите y второй точки:", 1);
            b = program.DurDub(Console.ReadLine());
            Point P2 = new Point(a, b);
            Console.WriteLine("P1=" + P1.ToString() + "\nP2="+P2.ToString());
            Console.WriteLine("Расстояние между двумя точками: " + P1.Dist(P2));
            --P1;
            Console.WriteLine("--P1 ="+ P1.ToString());
            P2= -P2;
            Console.WriteLine("-P2 ="+ P2.ToString());
            int A = (int)P2;
            double B = (double)P2;
            Console.WriteLine("Целая часть x P2 теперь "+A+ ". y P2 теперь " + B+ "!");
            Console.WriteLine("Расстояние между P1 и P2");
            Console.WriteLine(P1-P2);
            if (P1 - P2 != P1.Dist(P2))
                Console.WriteLine("Эй, я не окей!");
        }
    }
}
