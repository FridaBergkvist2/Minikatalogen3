using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Produkt> produkter = new List<Produkt>();

        produkter.Add(new Produkt("USB-laddare", 99));
        produkter.Add(new Bok("C# på riktigt", 249, "Anna Svensson"));

        foreach (Produkt p in produkter)
        {
            p.VisaInfo();
        }
    }
}