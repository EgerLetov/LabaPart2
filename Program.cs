using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
namespace Laba2_1
{
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
        public double ABS(double a) {
            if (a < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число!!! Мы перевели его в положительное.");
                return -a;
            }
            else
            {
                return a;
            }
        }
        public void FillTitans(Titans P)
        {
            
            P.Next = new Titans(null, "Колосальный титан", 37.55, 120.1);
            P.Next.Next = new Titans(null, "Титан молотобоец", 9.46, 81.9);
            P.Next.Next.Next = new Titans(null, "Титан прародитель", 245.65, 153.88);
            P.Next.Next.Next.Next = new Titans(null, "Звероподобный титан", 9.85, 38.7);
            P.Next.Next.Next.Next.Next = new Titans(null, "Челюсти", 3.64, 6.1);
            P.Next.Next.Next.Next.Next.Next = new Titans(null, "Челюсти крылатый", 3.64, 5.1);
            P.Next.Next.Next.Next.Next.Next.Next = new Titans(null, "Женская особь", 8.23, 36.6);
            P.Next.Next.Next.Next.Next.Next.Next.Next = new Titans(null, "Титан перевозчик", 2.34, 4.8);
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next = new Titans(null, "Бронированный титан", 9.07, 75.8);
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next = new Titans(null, "Зубастый титан", 3.64, 6.1);
        }
        public void FindTitan(Titans P, ref string N, ref double th, ref double tw)
        {
            while (N != "0")
            {
                Titans Num = P;
                do
                {
                    if (Num.name == N)
                    {
                        th = Num.CofH; tw = Num.CofW; 
                        return;
                    }
                    Num = Num.Next;
                } while (Num != null);
                Console.WriteLine("Такого титана нет в каталоге.\nВведите другое название:");
                N=Console.ReadLine();
            }
        }
        static void Main()
        {
            Program program = new Program();
            Titans titans = new Titans(null, "Атакующий титан", 8.75, 45.5);
            program.FillTitans(titans);
            //Console.WriteLine("Введите рост человека: ");
            //double Hight = program.ABS(program.DurDub(Console.ReadLine()));
            //Console.WriteLine("Введите вес человека: ");
            //double Weight = program.ABS(program.DurDub(Console.ReadLine()));
            //Console.WriteLine("Введите ваш обхват грудной клетки: ");
            //double Chest = program.ABS(program.DurDub(Console.ReadLine()));
            //Body Jan = new Body ( Hight, Weight, Chest );
            //Jan.tInt();
            //Console.WriteLine(Jan.ToString());
            Console.WriteLine("Введите ваш рост (в метрах): ");
            double Hight = program.ABS(program.DurDub(Console.ReadLine()));
            Console.WriteLine("Введите ваш вес (в килограммах): ");
            double Weight = program.ABS(program.DurDub(Console.ReadLine()));
            Console.WriteLine("Введите ваш обхват грудной клетки (в сантиметрах): ");
            double Chest = program.ABS(program.DurDub(Console.ReadLine()));
            Console.WriteLine("Как завут вашего титана: ");
            string TN = Console.ReadLine();
            double TH = 1;
            double TW = 1;
            program.FindTitan(titans, ref TN, ref TH, ref TW);
            AOT Eren = new AOT( TN, TH, TW, Hight, Weight, Chest);
            Eren.ToTitan();
            Eren.tInt();
            Console.WriteLine("Параметры титана: ");
            Console.WriteLine(Eren.ToString());
            Console.WriteLine("Радиус крика (в км): "+Eren.SkreemArea());
        }
    }
}
