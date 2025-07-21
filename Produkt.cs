public class Produkt
{
    public string namn;
    public double pris;

    public Produkt(string namn, double pris)
    {
        Namn = namn;
        Pris = pris;
    }


    public string Namn
    {
        get { return namn; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                namn = value;
        }
    }

    public double Pris
    {
        get { return pris; }
        set
        {
            if (value >= 0)
                pris = value;
        }
    }

    public virtual void VisaInfo()
    {
        Console.WriteLine($"{Namn} - {Pris} kr");
    }
    public override string ToString()
    {
        return $"{Namn} - {Pris} kr";
    }
}