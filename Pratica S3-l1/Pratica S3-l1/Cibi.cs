using System;
using System.Collections.Generic;

namespace Pratica_S3_l1
{
    internal static class Cibi
    {
        public static void Menu()
        {
            double total = 0;
            List<string> ordine = new List<string>();
            Console.WriteLine("==============MENU==============");
            Console.WriteLine("1: Coca Cola 150 ml (€ 2.50)");
            Console.WriteLine("2: Insalata di pollo (€ 5.20)");
            Console.WriteLine("3: Pizza Margherita (€ 10.00)");
            Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
            Console.WriteLine("5: Pz patatine fritte (€ 3.50)");
            Console.WriteLine("6: Insalata di riso (€ 8.00)");
            Console.WriteLine("7: Frutta di stagione (€ 5.00)");
            Console.WriteLine("8: Pizza fritta (€ 5.00)");
            Console.WriteLine("9: Piadina vegetariana (€ 6.00)");
            Console.WriteLine("10: Panino Hamburger (€ 7.90)");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");

            Console.WriteLine("Digita il numero del prodotto da ordinare");
            string scelta;
            do
            {
                scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.WriteLine("Hai aggiunto: Coca cola 150 ml al prezzo di 2.5");
                        total += 2.5;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Coca Cola 150 ml");
                        break;
                    case "2":
                        Console.WriteLine("Hai Aggiunto: Insalata di pollo 5.5");
                        total += 5.5;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Insalata di pollo");
                        break;
                    case "3":
                        Console.WriteLine("Hai Aggiunto: Pizza Margherita (€ 10.00)");
                        total += 10.00;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Pizza Margherita");
                        break;
                    case "4":
                        Console.WriteLine("Hai Aggiunto: Pizza 4 Formaggi (€ 12.50)");
                        total += 12.50;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Pizza 4 Formaggi");
                        break;
                    case "5":
                        Console.WriteLine("Hai Aggiunto:Pz patatine fritte (€ 3.50)");
                        total += 3.50;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Pz patatine fritte");
                        break;
                    case "6":
                        Console.WriteLine("Hai Aggiunto: Insalata di riso (€ 8.00)");
                        total += 8.00;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Insalata di riso");
                        break;
                    case "7":
                        Console.WriteLine("Hai Aggiunto:  Frutta di stagione (€ 5.00)");
                        total += 5.00;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Frutta di stagione");
                        break;
                    case "8":
                        Console.WriteLine("Hai Aggiunto: Pizza fritta (€ 5.00)");
                        total += 5.00;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Pizza fritta");
                        break;
                    case "9":
                        Console.WriteLine("Hai Aggiunto: Piadina vegetariana (€ 6.00)");
                        total += 6.00;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Piadina vegetariana");
                        break;
                    case "10":
                        Console.WriteLine("Hai Aggiunto: Panino Hamburger (€ 7.90)");
                        total += 7.90;
                        Console.WriteLine($"Il totale del tuo carrello è {total}");
                        ordine.Add("Panino Hamburger");
                        break;
                    default:
                        Console.WriteLine("Non valido");
                        break;
                }
            } while (scelta != "11");
            if (scelta == "11")
            {
                Console.WriteLine("Nel tuo carrello ci sono i seguenti prodotti: ");
                foreach (string item in ordine)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"il totale è: {total} ");

            }
            Console.ReadLine();

        }
    }
}