using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Produkt> produkter = new List<Produkt>();
        bool kör = true;

        while (kör)
        {
Console.Clear();
Console.WriteLine("Fridas Minikatalog 2");
Console.WriteLine("1. Lägg till produkt");
Console.WriteLine("2. Visa alla produkter");
Console.WriteLine("3. Avsluta");
Console.Write("Välj ett alternativ (1-3):");

string val = Console.ReadLine();

switch (val)
            {
case "1":     
{   
Console.Write("Ange produktnamn (eller skriv 'stopp' för att avsluta): ");
            string namn = Console.ReadLine();

            if (namn.ToLower() == "stopp")
            {
                kör = false;
                break;
            }

            Console.Write("Ange pris: ");
            double pris = Convert.ToDouble(Console.ReadLine());

            produkter.Add(new Produkt(namn, pris));

        Console.WriteLine("\n Produkten har lagts till");
Console.WriteLine("Tryck på valfri tangent för att fortsätta.");
                    Console.ReadKey();
                    break;
}
case "2":
{ 
Console.WriteLine("\n Alla produkter i Fridas katalog");
if (produkter.Count == 0)
        {
            Console.WriteLine("Lägg till en produkt först för tusan.");
        }
else
        {
        foreach (Produkt p in produkter)
        {
p.VisaInfo();
    }
}
                    Console.WriteLine("Tryck på valfri tangent för att fortsätta.");
                    Console.ReadKey();
                    break;
                }
case "3":
{ 
kör = false;
break;
}
            }
        }
    }
}