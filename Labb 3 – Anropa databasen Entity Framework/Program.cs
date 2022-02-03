using Labb_3___Anropa_databasen_Entity_Framework.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Labb_3___Anropa_databasen_Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Labb3 Context = new Labb3();

            bool meny = true;
            while (meny == true)
            {
                Console.Clear();
                Console.WriteLine("Välj ett alternativ nedan, Mata in siffran som representerar ditt val.");
                Console.WriteLine("1 --- Hämta ut alla elever."); // Hämta ut alla elever (ska lösas med Entity framwork) Användaren får välja om de vill se eleverna sorterade på för- eller efternamn och om det ska vara stigande eller fallande sortering.
                Console.WriteLine("2 --- Hämta ut alla elever i en viss klass."); // Hämta ut alla elever i en viss klass (ska lösas med Entity framework) Användaren ska först få se en lista med alla klasser som finns, sen får användaren välja en av klasserna och då skrivs alla elever i den klassen ut.
                Console.WriteLine("3 --- Lägga till ny personal."); // Lägga till ny personal (ska lösas genom Entity framework) Användaren får möjlighet att mata in uppgifter om en ny anställd och dessa sparas ner i databasen.
                Console.WriteLine("4 --- Avsluta programmet.");

                string huvudMenyVal = Console.ReadLine();

                Console.Clear();
                switch (huvudMenyVal)
                {
                    case "1":
                        Console.WriteLine("Ska eleverna sorteras på för eller efternamn? Mata in siffran som representerar ditt val." +
                            "\n1 --- Förnamn." +
                            "\n2 --- Efternamn.");

                        string HämtaUtAllaEleverVal = "0";
                        bool loopCase1 = true;
                        while (loopCase1 == true)
                        {
                            HämtaUtAllaEleverVal = Console.ReadLine();

                            if (HämtaUtAllaEleverVal == "1" || HämtaUtAllaEleverVal == "2")
                            {
                                loopCase1 = false;
                            }
                            else
                            {
                                Console.WriteLine("Ogiltigt val, försök igen.");
                            }
                        }

                        Console.Clear();

                        switch (HämtaUtAllaEleverVal)
                        {
                            case "1":
                                Console.WriteLine("Ska eleverna sorteras på ett eller stigande fallande vis? Mata in siffran som representerar ditt val." +
                                    "\n1 --- Stigande." +
                                    "\n2 --- Fallande.");

                                string SorteraElevernaFörnamn = "0";
                                loopCase1 = true;
                                while (loopCase1 == true)
                                {
                                    SorteraElevernaFörnamn = Console.ReadLine();

                                    if (SorteraElevernaFörnamn == "1" || SorteraElevernaFörnamn == "2")
                                    {
                                        loopCase1 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ogiltigt val, försök igen.");
                                    }
                                }

                                Console.Clear();

                                if (SorteraElevernaFörnamn == "1")
                                {
                                    var AllaEleverna = from ElevTbl in Context.ElevTbl orderby ElevTbl.ElevFörnamn ascending select ElevTbl;

                                    Console.WriteLine("Nedan visas alla elever, i bokstavsordning baserat på förnamn och på stigande vis.");
                                    Console.WriteLine();

                                    foreach (var elev in AllaEleverna)
                                    {
                                        Console.WriteLine($"Elevens id: {elev.ElevId}");
                                        Console.WriteLine($"Elevens personnummer: {elev.ElevPersonnummer}");
                                        Console.WriteLine($"Elevens förnamn: {elev.ElevFörnamn}");
                                        Console.WriteLine($"Elevens efternamn: {elev.ElevEfternamn}");
                                        Console.WriteLine($"Elevens kön: {elev.ElevKön}");
                                        Console.WriteLine($"Elevens klass: {elev.ElevKlass}");
                                        Console.WriteLine(new string('-', (20)));
                                    }
                                }
                                else if (SorteraElevernaFörnamn == "2")
                                {
                                    var AllaEleverna = from ElevTbl in Context.ElevTbl orderby ElevTbl.ElevFörnamn descending select ElevTbl;

                                    Console.WriteLine("Nedan visas alla elever, i bokstavsordning baserat på förnamn och på fallande vis.");
                                    Console.WriteLine();

                                    foreach (var elev in AllaEleverna)
                                    {
                                        Console.WriteLine($"Elevens id: {elev.ElevId}");
                                        Console.WriteLine($"Elevens personnummer: {elev.ElevPersonnummer}");
                                        Console.WriteLine($"Elevens förnamn: {elev.ElevFörnamn}");
                                        Console.WriteLine($"Elevens efternamn: {elev.ElevEfternamn}");
                                        Console.WriteLine($"Elevens kön: {elev.ElevKön}");
                                        Console.WriteLine($"Elevens klass: {elev.ElevKlass}");
                                        Console.WriteLine(new string('-', (20)));
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine("******************************************");
                                Console.WriteLine();
                                Console.WriteLine("Tryck på enter för att återgå till huvudmenyn.");
                                Console.ReadKey();
                                break;

                            case "2":
                                Console.WriteLine("Ska eleverna sorteras på ett eller stigande fallande vis? Mata in siffran som representerar ditt val." +
                                    "\n1 --- Stigande." +
                                    "\n2 --- Fallande.");

                                string SorteraElevernaEfternamn = "0";
                                loopCase1 = true;
                                while (loopCase1 == true)
                                {
                                    SorteraElevernaEfternamn = Console.ReadLine();

                                    if (SorteraElevernaEfternamn == "1" || SorteraElevernaEfternamn == "2")
                                    {
                                        loopCase1 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ogiltigt val, försök igen.");
                                    }
                                }

                                Console.Clear();

                                if (SorteraElevernaEfternamn == "1")
                                {
                                    var AllaEleverna = from ElevTbl in Context.ElevTbl orderby ElevTbl.ElevEfternamn ascending select ElevTbl;

                                    Console.WriteLine("Nedan visas alla elever, i bokstavsordning baserat på efternamn och på stigande vis.");
                                    Console.WriteLine();

                                    foreach (var elev in AllaEleverna)
                                    {
                                        Console.WriteLine($"Elevens id: {elev.ElevId}");
                                        Console.WriteLine($"Elevens personnummer: {elev.ElevPersonnummer}");
                                        Console.WriteLine($"Elevens förnamn: {elev.ElevFörnamn}");
                                        Console.WriteLine($"Elevens efternamn: {elev.ElevEfternamn}");
                                        Console.WriteLine($"Elevens kön: {elev.ElevKön}");
                                        Console.WriteLine($"Elevens klass: {elev.ElevKlass}");
                                        Console.WriteLine(new string('-', (20)));
                                    }
                                }
                                else if (SorteraElevernaEfternamn == "2")
                                {
                                    var AllaEleverna = from ElevTbl in Context.ElevTbl orderby ElevTbl.ElevEfternamn descending select ElevTbl;

                                    Console.WriteLine("Nedan visas alla elever, i bokstavsordning baserat på efternamn och på fallande vis.");
                                    Console.WriteLine();

                                    foreach (var elev in AllaEleverna)
                                    {
                                        Console.WriteLine($"Elevens id: {elev.ElevId}");
                                        Console.WriteLine($"Elevens personnummer: {elev.ElevPersonnummer}");
                                        Console.WriteLine($"Elevens förnamn: {elev.ElevFörnamn}");
                                        Console.WriteLine($"Elevens efternamn: {elev.ElevEfternamn}");
                                        Console.WriteLine($"Elevens kön: {elev.ElevKön}");
                                        Console.WriteLine($"Elevens klass: {elev.ElevKlass}");
                                        Console.WriteLine(new string('-', (20)));
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine("******************************************");
                                Console.WriteLine();
                                Console.WriteLine("Tryck på enter för att återgå till huvudmenyn.");
                                Console.ReadKey();
                                break;

                            default:
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Välj en klass nedan för att se vilka elever som går i den klassen, genom att mata in namnet på just den klassen.");
                        Console.WriteLine();

                        var Klasser = from ElevTbl in Context.ElevTbl orderby ElevTbl.ElevKlass select ElevTbl;
                        List<string> listaAvKlasser = new List<string>();

                        foreach (var klass in Klasser)
                        {
                            listaAvKlasser.Add(klass.ElevKlass);
                        }

                        var resultat = listaAvKlasser.Distinct();

                        foreach (var klass in resultat)
                        {
                            Console.WriteLine($"Klassens namn: {klass}");
                            Console.WriteLine(new string('-', (20)));
                        }

                        string valAvKlass = "0";
                        bool loopCase2 = true;
                        while (loopCase2 == true)
                        {
                            valAvKlass = Console.ReadLine();

                            if (listaAvKlasser.Contains(valAvKlass.ToUpper()))
                            {
                                loopCase2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Ogiltigt val, försök igen.");
                            }
                        }

                        Console.Clear();

                        var ValdKlass = from ElevTbl in Context.ElevTbl where valAvKlass.ToUpper() == ElevTbl.ElevKlass orderby ElevTbl.ElevEfternamn select ElevTbl;

                        Console.WriteLine("Nedan visas alla elever som går i klassen " + valAvKlass.ToUpper() + ".");
                        Console.WriteLine();

                        foreach (var elev in ValdKlass)
                        {
                            Console.WriteLine($"Elevens id: {elev.ElevId}");
                            Console.WriteLine($"Elevens personnummer: {elev.ElevPersonnummer}");
                            Console.WriteLine($"Elevens förnamn: {elev.ElevFörnamn}");
                            Console.WriteLine($"Elevens efternamn: {elev.ElevEfternamn}");
                            Console.WriteLine($"Elevens kön: {elev.ElevKön}");
                            Console.WriteLine($"Elevens klass: {elev.ElevKlass}");
                            Console.WriteLine(new string('-', (20)));
                        }
                        Console.WriteLine();
                        Console.WriteLine("******************************************");
                        Console.WriteLine();
                        Console.WriteLine("Tryck på enter för att återgå till huvudmenyn.");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Vilket förnamn ska den nya anställda ha?");
                        string förnamnPåNyanställd = Console.ReadLine();
                        Console.WriteLine("Vilket efternamn ska den nya anställda ha?");
                        string efternamnPåNyanställd = Console.ReadLine();

                        Console.Clear();
                        string valKön = "0";
                        string könPåNyanställd = "0";
                        bool loopCase3 = true;
                        while (loopCase3 == true)
                        {
                            Console.WriteLine("Vilket kön ska den nya anställda ha? Välj genom att mata in rätt siffra.");
                            Console.WriteLine("1 --- Man.");
                            Console.WriteLine("2 --- Kvinna.");
                            valKön = Console.ReadLine();

                            if (valKön == "1")
                            {
                                könPåNyanställd = "Man";
                                loopCase3 = false;
                            }
                            else if (valKön == "2")
                            {
                                könPåNyanställd = "Kvinna";
                                loopCase3 = false;
                            }
                            else
                            {
                                Console.WriteLine("Ogiltigt val, försök igen.");
                            }
                        }

                        Console.Clear();
                        int yrkePåNyanställd = 0;
                        loopCase3 = true;
                        while (loopCase3 == true)
                        {
                            Console.WriteLine("Vilket yrke ska den nya anställda ha?");
                            Console.WriteLine("1 --- Lärare.");
                            Console.WriteLine("2 --- Vaktmästare.");
                            Console.WriteLine("3 --- Administratör.");
                            Console.WriteLine("4 --- Rektor.");
                            try
                            {
                                yrkePåNyanställd = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {


                            }
                            if (yrkePåNyanställd == 1 || yrkePåNyanställd == 2 || yrkePåNyanställd == 3 || yrkePåNyanställd == 4)
                            {
                                loopCase3 = false;
                            }
                            else
                            {
                                Console.WriteLine("Ogiltigt val, försök igen.");
                            }
                        }

                        var Id = from PersonalTbl in Context.PersonalTbl orderby PersonalTbl.PersonalId ascending select PersonalTbl;

                        Context.Add(new PersonalTbl()
                        {
                            PersonalId = Id.Count() + 1,
                            PersonalFörnamn = förnamnPåNyanställd,
                            PersonalEfternamn = efternamnPåNyanställd,
                            PersonalKön = könPåNyanställd,
                            PersonalYrkesrollFk = yrkePåNyanställd
                        });

                        Context.SaveChanges();

                        Console.WriteLine($"Du har nu lagt till en ny personalmedlem som har förnamnet {förnamnPåNyanställd}, efternamnet {efternamnPåNyanställd}, könet {könPåNyanställd} och yrket {yrkePåNyanställd}.");
                        Console.WriteLine();
                        Console.WriteLine("******************************************");
                        Console.WriteLine();
                        Console.WriteLine("Tryck på enter för att återgå till huvudmenyn.");
                        Console.ReadKey();
                        break;

                    case "4":
                        meny = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
