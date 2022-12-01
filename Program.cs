Console.WriteLine("Beregn kondital ud fra pulsværdier: ");
double hvilepuls = IndtastAfVærdi("Indtast hvilepuls: ");
double maxpuls = IndtastAfVærdi("Indtast maxpuls: ");
double vægt = IndtastAfVærdi("Indtast din vægt: ");

Thread.Sleep(1000);
Console.Clear();

Kondital kondital = new Kondital();
double kondital1 = kondital.beregnAfKondital(hvilepuls, maxpuls);
Console.WriteLine("---------------------\nKondital er: {0}", (short)kondital.beregnAfKondital(hvilepuls, maxpuls));
Console.WriteLine("Ilt Optagelse: {0:F1} \n---------------------", (kondital.maxIltOptagelse(vægt, kondital1)));

static double IndtastAfVærdi(string textinput)
{
    double værdi;
    while (true)
    {
        Console.Write(textinput);
        try
        {
            return værdi = Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception y)
        {
            Console.WriteLine("FAIL");
        }
    }
}

class Kondital
{
    public double beregnAfKondital(double hvilepuls, double maxpuls)
    {
        return (maxpuls / hvilepuls) * 15.3;
    }
    public double maxIltOptagelse(double vægt, double kondital)
    {
        return kondital * vægt / 1000;
    }
}