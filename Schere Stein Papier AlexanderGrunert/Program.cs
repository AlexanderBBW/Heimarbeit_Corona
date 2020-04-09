using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Program
    {
        static void Main(string[] args)
        {
            Eingabe();
        }

        static void Eingabe()
        {
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 5 ein!");
            Console.WriteLine("1 = Schere");
            Console.WriteLine("2 = Stein ");
            Console.WriteLine("3 = Papier");
            Console.WriteLine("4 = Echse");
            Console.WriteLine("5 = Spock");
            var BenutzerEingabe = Console.ReadLine();
            check_eingabe(BenutzerEingabe);
        }

        static void check_eingabe(string Wert)
        {
            switch (Wert)
            {
                case "1":
                    computer_zieht(1);
                    break;
                case "2":
                    computer_zieht(2);
                    break;
                case "3":
                    computer_zieht(3);
                    break;
                case "4":
                    computer_zieht(4);
                    break;
                case "5":
                    computer_zieht(5);
                    break;
                default:
                    Console.WriteLine("Keine gültige Eingabe!");
                    Eingabe();
                    break;
            }
        }

        static void computer_zieht(int Wert)
        {
            Random random = new Random();
            int randomNumb = random.Next(1, 6);
            Vergleich(randomNumb, Wert);
        }

        static void Vergleich(int Computerwahl, int BenutzerEingabe)
        {
            Console.WriteLine("Computer hat: " + wert_wort(Computerwahl));
            Console.WriteLine("Benutzer hat: " + wert_wort(BenutzerEingabe));

            switch (Computerwahl)
            {
                case 1:
                    switch (BenutzerEingabe)
                    {
                        case 1:
                            Console.WriteLine("Niemand hat Gewonnen!");
                            break;
                        case 2:
                            Console.WriteLine("Stein schleift Schere");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                        case 3:
                            Console.WriteLine("Schere schneidet Papier");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                        case 4:
                            Console.WriteLine("Schere köpft Echse");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                        case 5:
                            Console.WriteLine("Spock zertrummert Schere");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                    }
                    break;
                case 2:
                    switch (BenutzerEingabe)
                    {
                        case 1:
                            Console.WriteLine("Stein schleift Schere");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                        case 2:
                            Console.WriteLine("Niemand hat Gewonnen!");
                            break;
                        case 3:
                            Console.WriteLine("Papier bedeckt Stein");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                        case 4:
                            Console.WriteLine("Stein zerquetscht Echse");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                        case 5:
                            Console.WriteLine("Spock verdampft Stein");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                    }
                    break;
                case 3: // Papier
                    switch (BenutzerEingabe)
                    {
                        case 1:
                            Console.WriteLine("Schere schneidet Papier");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                        case 2:
                            Console.WriteLine("Papier bedeckt Stein");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                        case 3:
                            Console.WriteLine("Niemand hat Gewonnen!");
                            break;
                        case 4:
                            Console.WriteLine("Echse frisst Papier");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                        case 5:
                            Console.WriteLine("Papier wiederlegt Spock");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                    }
                    break;
                case 4: // Echse
                    switch (BenutzerEingabe)
                    {
                        case 1:
                            Console.WriteLine(" Schere köpft Echse");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                        case 2:
                            Console.WriteLine("Stein zerquetscht Echse");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                        case 3:
                            Console.WriteLine("Echse frisst Papier");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                        case 4:
                            Console.WriteLine("Niemand hat Gewonnen!");
                            break;
                        case 5:
                            Console.WriteLine("Echse vergiftet Spock");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                    }
                    break;
                case 5: // Spock
                    switch (BenutzerEingabe)
                    {
                        case 1:
                            Console.WriteLine(" Spock zertrummert Schere ");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                        case 2:
                            Console.WriteLine("Spock verdampft Stein");
                            Console.WriteLine("Der Computer hat Gewonnen!");
                            break;
                        case 3:
                            Console.WriteLine("Papier widerlegt Spock");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                        case 4:
                            Console.WriteLine(" Echse vergiftet Spock");
                            Console.WriteLine("Der Benutzer hat Gewonnen!");
                            break;
                        case 5:
                            Console.WriteLine("Niemand hat Gewonnen!");
                            break;
                    }
                    break;
            }
            AbfrageBeenden();
        }

        static string wert_wort(int Wert)
        {
            var returnwert = "";
            switch (Wert)
            {
                case 1:
                    returnwert = "Schere";
                    break;
                case 2:
                    returnwert = "Stein";
                    break;
                case 3:
                    returnwert = "Papier";
                    break;
                case 4:
                    returnwert = "Echse";
                    break;
                case 5:
                    returnwert = "Spock";
                    break;
            }
            return returnwert;
        }

        static void AbfrageBeenden()
        {
            Console.WriteLine("Möchtest du Jetzt beenden?");
            Console.WriteLine("Wenn Ja einfach 'Enter drücken' sonst 'nein' eingeben um von vorne zu spielen");
            var beenden = Console.ReadLine().ToLower();
            if (beenden == "nein")
            {
                Eingabe();
            }
            else
            {
                Exit();
            }
        }
        static void Exit()
        {
            Environment.Exit(1);
        }
    }
}