public class Bok : Produkt
{
    public string Författare { get; set; }

    public Bok(string namn, double pris, string författare) : base(namn, pris)
    {
        Författare = författare;
    }

    public override void VisaInfo()
    {
        Console.WriteLine($"{Namn} (Bok av {Författare}) - {Pris} kr");
    }
}