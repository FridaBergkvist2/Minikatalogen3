using System;

public class Bok : Produkt
{
    public string Författare { get; set; }
    public string Snygghet { get; set; }

    public Bok(string namn, double pris, string författare, string snygghet)
        : base(namn, pris)
    {
        Författare = författare;
        Snygghet = snygghet;
    }

    public override void VisaInfo()
    {
        Console.WriteLine($"{Namn} (Bok av {Författare}) (Blingfaktor: {Snygghet}) - {Pris} kr");
    }
}