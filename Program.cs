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
    class Titans
    {
        public Titans Next;
        public string name;
        public double CofH;
        public double CofW;
    }


    class Body
    {
        protected double hight { get; set; }
        protected double weight { get; set; }
        protected double chest { get; set; }
        public Body(double H, double W, double C)
        {
            this.hight = H;
            this.weight = W;
            this.chest = C;
        }
        public void tInt()
        {
            this.hight = Math.Round(this.hight);
            this.weight = Math.Round(this.weight);
            this.chest = Math.Round(this.chest);
        }



        public override string ToString()
        {
            return $"Рост: {hight}\nВес: {weight}\nОбхват груди: {chest}";
        }
    }

    class AOT : Body
    {
        public string titan_name { get; set; }
        public double titan_h_cof { get; set; }
        public double titan_w_cof { get; set; }

        public AOT(string titan_name, double titan_h_cof, double titan_w_cof, double hight, double weight, double chest) : base(hight, weight, chest)
        {
            this.titan_name = titan_name;
            this.titan_h_cof = titan_h_cof;
            this.titan_w_cof = titan_w_cof;
        }


        public void ToTitan()
        {
            this.hight *= titan_h_cof;
            this.chest *= titan_h_cof;
            this.weight *= titan_w_cof;

        }
        public long SkreemArea()
        {
            return (long)(this.chest *  8 / 27);
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
            P.name = "Атакующий титан";
            P.CofH = 8.75;
            P.CofW = 45.5;
            P.Next = new Titans();
            P.Next.name = "Колосальный титан";
            P.Next.CofH = 37.55;
            P.Next.CofW = 120.1;
            P.Next.Next = new Titans();
            P.Next.Next.name = "Титан молотобоец";
            P.Next.Next.CofH = 9.46;
            P.Next.Next.CofW = 81.9;
            P.Next.Next.Next = new Titans();
            P.Next.Next.Next.name = "Титан прародитель";
            P.Next.Next.Next.CofH = 245.65;
            P.Next.Next.Next.CofW = 153.88;
            P.Next.Next.Next.Next = new Titans();
            P.Next.Next.Next.Next.name = "Звероподобный титан";
            P.Next.Next.Next.Next.CofH = 9.85;
            P.Next.Next.Next.Next.CofW = 38.7;
            P.Next.Next.Next.Next.Next = new Titans();
            P.Next.Next.Next.Next.Next.name = "Челюсти";
            P.Next.Next.Next.Next.Next.CofH = 3.64;
            P.Next.Next.Next.Next.Next.CofW = 6.1;
            P.Next.Next.Next.Next.Next.Next = new Titans();
            P.Next.Next.Next.Next.Next.Next.name = "Челюсти крылатый";
            P.Next.Next.Next.Next.Next.Next.CofH = 3.64;
            P.Next.Next.Next.Next.Next.Next.CofW = 5.1;
            P.Next.Next.Next.Next.Next.Next.Next = new Titans();
            P.Next.Next.Next.Next.Next.Next.Next.name = "Женская особь";
            P.Next.Next.Next.Next.Next.Next.Next.CofH = 8.23;
            P.Next.Next.Next.Next.Next.Next.Next.CofW = 36.6;
            P.Next.Next.Next.Next.Next.Next.Next.Next = new Titans();
            P.Next.Next.Next.Next.Next.Next.Next.Next.name = "Титан перевозчик";
            P.Next.Next.Next.Next.Next.Next.Next.Next.CofH = 2.34;
            P.Next.Next.Next.Next.Next.Next.Next.Next.CofW = 4.8;
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next = new Titans();
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next.name = "Бронированный титан";
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next.CofH = 9.07;
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next.CofW = 75.8;
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next = new Titans();
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next.name = "Зубастый титан";
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next.CofH = 3.64;
            P.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next.CofW = 6.1;

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
            Titans titans = new Titans();
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
