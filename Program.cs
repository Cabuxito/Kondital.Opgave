Console.WriteLine("Beregn kondital ud fra pulsværdier: ");
double hvilepuls = IndtastAfVærdi("Indtast hvilepuls: ");
double maxpuls = IndtastAfVærdi("Indtast maxpuls: ");
double vægt = IndtastAfVærdi("Indtast din vægt: ");













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