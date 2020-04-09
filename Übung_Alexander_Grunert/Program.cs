using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_Alexander_Grunert
{
    class Program
    {
        static void Main(string[] args)
        {
            Eingabe();
        }
        static void Eingabe()
        {
            Console.WriteLine("Wählen Sie eine Funktion aus!");
            Console.WriteLine("Drücken Sie 1,2,3,4,5 um einer der Funktionen auszuwählen!");
            switch ((Console.ReadLine()))
            {
                case "1":
                    Ausgabe1();
                    break;
                case "2":
                    Ausgabe2();
                    break;
                case "3":
                    Ausgabe3();
                    break;
                case "4":
                    Eingabe4();
                    break;
                case "5":
                    Ausgabe5();
                    break;
            }
        }
        static void Ausgabe1()
        {
            var i = 0;
            while (i <= 98)
            {
                i++;
                {

                    Console.WriteLine(i);
                }
            }
            Anzeigen1(i);
        }
        static void Ausgabe2()
        {
            var i = 0;
            while (i <= 98)
            {
                i++;
                if (i % 2 == 0)
                {

                    Console.WriteLine(i);
                }
            }
            Anzeigen1(i);
        }
        static void Ausgabe3()
        {
            var i = 0;
            while (i <= 98)
            {
                i++;
                if (i % 3 == 0 && i % 5 == 0)
                {

                    Console.WriteLine(i);
                }
            }
            Anzeigen1(i);
        }
        static void Eingabe4()
        {
            int eingabe4 = Convert.ToInt32(Console.ReadLine());
            Berechnung4(eingabe4);
        }
        static void Berechnung4(int eingabe4)
        {
            for (int i = 2; i <= eingabe4; i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.WriteLine(i);
                }
            }
            Ausgabe4();
        } 
        static void Ausgabe4()
        {
            Anzeigen3();
        }
        static void Ausgabe5()
        {
            int dez;

            string bin;

            Console.WriteLine("Geben Sie eine Dezimalzahl ein:");

            dez = Convert.ToInt32(Console.ReadLine());

            bin = Convert.ToString(dez, 2);

            Console.Write( bin);
            
            Anzeigen2(bin);
        }
        static void Anzeigen1(int i)
        {
            Console.WriteLine("Geben Sie '1' ein um zur Auswahl zu kommen!");
            if (Console.ReadLine() == "1")
            {
                Eingabe();
            }
            else
            {
                Ende();
            }
        }
        static void Anzeigen2(string bin)
        {
            Console.WriteLine("Geben Sie '1' ein um weiter zu machen!");
            if (Console.ReadLine() == "1")
            {
                Eingabe();
            }
            else
            {
                Ende();
            }
        }
        static void Anzeigen3()
        {
            if (Console.ReadLine() == "1")
            {
                Eingabe();
            }
            else
            {
                Ende();
            }
        }
        static void Ende()
        {
            Environment.Exit(1);
        }
    }
}
