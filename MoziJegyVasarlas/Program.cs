using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoziJegyVasarlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PETRIK MOZI ===");
            Console.WriteLine("1.) Jegyvásárlás");
            Console.WriteLine("2.) Filmek");
            Console.WriteLine("3.) Kilépés");
            Console.Write("Válassz: ");
            try
            {
                int valasz = Convert.ToInt32(Console.ReadLine());
                switch (valasz)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("==== Jegyvásárlás ===");
                        Console.Write("Mi a neved? ");
                        string nev = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Hány éves vagy? ");
                        try
                        {
                            int eletkor = Convert.ToInt32(Console.ReadLine());
                            if (eletkor >= 65) {
                                Console.WriteLine($"Szia {nev}");
                                Console.WriteLine("A számodra megfelelő jegy: Nyugdías jegy");
                                Console.WriteLine("Fizetendő: 1800Ft");
                                Console.ReadLine();
                            }
                            else if (eletkor >= 18) {
                                Console.WriteLine($"Szia {nev}");
                                Console.WriteLine("A számodra megfelelő jegy: Felnőtt jegy");
                                Console.WriteLine("Fizetendő: 3000Ft");
                                Console.ReadLine();
                            }
                            else if (eletkor >= 12) {
                                Console.WriteLine($"Szia {nev}");
                                Console.WriteLine("A számodra megfelelő jegy: Diák jegy");
                                Console.WriteLine("Fizetendő: 2000Ft");
                                Console.ReadLine();
                            }
                            else {
                                Console.WriteLine($"Szia {nev}");
                                Console.WriteLine("A számodra megfelelő jegy: Gyerek jegy");
                                Console.WriteLine("Fizetendő: 1500Ft");
                                Console.ReadLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Csak számot lehet megadni");
                            Console.WriteLine(ex);
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== MAI FILMEK ===");
                        Console.WriteLine("1.) Minecraft film");
                        Console.WriteLine("2.) Bosszúállók");
                        Console.WriteLine("3.) Shrek");
                        Console.Write("Melyiket választod? ");
                        try
                        {
                            int film = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            switch (film)
                            {
                                case 1: Console.WriteLine("A Minecraft kiválasztottad");
                                    Console.ReadLine();
                                    break;
                                case 2: Console.WriteLine("A Bosszuálókat választottad");
                                    Console.ReadLine();
                                    break;
                                case 3: Console.WriteLine("A Shreket választottad");
                                    Console.ReadLine();
                                    break;
                                default: Console.WriteLine("Nincs ilyen film");
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Csak számot adhatsz meg");
                            Console.WriteLine(ex);
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nincs ilyen opció");
                        Console.ReadLine();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Csak számot lehet megadni");
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
