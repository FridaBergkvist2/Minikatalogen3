public class Produkt
{
    public string Namn { get; set; }
    public double Pris { get; set; }

    public Produkt(string namn, double pris)
    {
        Namn = namn;
        Pris = pris;
    }

    public void VisaInfo()
    {
        Console.WriteLine($"{Namn} - {Pris} kr");
    }
}