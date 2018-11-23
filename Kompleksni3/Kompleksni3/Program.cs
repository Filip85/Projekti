using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompleksni3
{
    class Program
    {
        public class Kompleksni
        {
            public double Re, Im;
            public double  broj;

            /*public Kompleksni()
            {
                Console.WriteLine("Defultni komstruktor");
            }

            public Kompleksni(int x, int y)
            {
                Re = x;
                Im = y;
            }*/

            public void Upis()
            {
                Re = Convert.ToInt32(Console.ReadLine());
                Im = Convert.ToInt32(Console.ReadLine());
            }

            public void Zbroj(Kompleksni z1, Kompleksni z2)
            {
                Re = z1.Re + z2.Re;
                Im = z1.Im + z2.Im;
            }

            public void Razlika(Kompleksni z3, Kompleksni z4)
            {
                Re = z3.Re - z4.Re;
                Im = z3.Im - z4.Im;
            }

            public void Umnozak(Kompleksni z5, Kompleksni z6)
            {
                Re = (z5.Re * z6.Re) - (z5.Im * z6.Im);
                Im = (z5.Im * z6.Re) + (z5.Re * z6.Im);
            }

            public void Kolicnik(Kompleksni z7, Kompleksni z8)
            {  
               Re = (((z7.Re * z8.Re) + (z7.Im * z8.Im))) / ((Math.Pow(z8.Re, 2)) + Math.Pow(z8.Im, 2));
               Im = (((z7.Im * z8.Re) - (z7.Re * z8.Im))) / ((Math.Pow(z8.Re, 2)) + Math.Pow(z8.Im, 2));
            }

            public void Modul(Kompleksni z9)
            {
                broj = Math.Sqrt(Math.Pow(z9.Re, 2) + Math.Pow(z9.Im, 2));
            }

            public void Ispis1()
            {
                Console.WriteLine("{0} + {1}i", Re, Im);
            }

            public void Ispis2()
            {
                Console.WriteLine("{0}", broj);
            }
        }
        static void Main(string[] args)
        {
            Kompleksni Kom1 = new Kompleksni();
            Kompleksni Kom2 = new Kompleksni();
            Kompleksni Kom3 = new Kompleksni();
            Kompleksni Kom4 = new Kompleksni();
            Kompleksni Kom5 = new Kompleksni();
            Kompleksni Kom6 = new Kompleksni();
            Kompleksni Kom7 = new Kompleksni();
            Kompleksni Kom8 = new Kompleksni();
            Kompleksni Kom9 = new Kompleksni();

            Console.WriteLine("Upisi 2 broja:");
            Console.WriteLine();
            Kom1.Upis();
            Kom1.Ispis1();
            Console.WriteLine();
            Kom2.Upis();
            Kom2.Ispis1();

            Console.WriteLine();
            Console.WriteLine("Unesite broj 1 - 5");
            int Number = int.Parse(Console.ReadLine());

            switch (Number)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Zbroj dva kompleksna broja je:");
                    Console.WriteLine();
                    Kom3.Zbroj(Kom1, Kom2);
                    Kom3.Ispis1();
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Razlika 2 komplekasna broja je:");
                    Kom4.Razlika(Kom1, Kom2);
                    Kom4.Ispis1();
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Umnozak 2 kompleksna broja je:");
                    Kom5.Umnozak(Kom1, Kom2);
                    Kom5.Ispis1();
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Kolicnik 2 kompleksna broja je:");
                    if (((Math.Pow(Kom2.Re, 2)) + Math.Pow(Kom2.Im, 2)) != 0)
                    {
                        Kom6.Kolicnik(Kom1, Kom2);
                        Kom6.Ispis1();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Operacija se ne moze izvrsiti:");
                    }
                    break;

                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Modul 2 kompleksna broja:");
                    Kom7.Modul(Kom1);
                    Kom8.Modul(Kom2);
                    Kom7.Ispis2();
                    Kom8.Ispis2();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Uneseni broj je neispravan. Pokusjte opet!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
