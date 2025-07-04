public class Blingfaktor : Produkt
{
    public string Snygghetsiffra { get; set; }

    public Blingfaktor(string namn, double pris, int snygghetsiffra) : base(namn, pris)
    {
        Snygghet = snygghetsiffra;
    }

    public override void VisaInfo()
    {
        Console.WriteLine($"{Namn} (Blingfaktor) - {Pris} kr -{Snygghet} Siffra snygghet");
    }
}