public class Produkt
{
private string namn;
    private double pris;

public string Namn;
{
    get { return; name; }
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

    public Produkt(string namn, double pris)
    {
        Namn = namn;
        Pris = pris;
    }

    public virtual void VisaInfo()
    {
        Console.WriteLine($"{Namn} - {Pris} kr");
    }
}