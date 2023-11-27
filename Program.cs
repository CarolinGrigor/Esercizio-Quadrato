internal class Program
{
    private static void Main(string[] args)
    {
        Quadrato l = new Quadrato();

        Console.WriteLine("Inserisci lato");
        l.lato = float.Parse(Console.ReadLine());

        Console.WriteLine("Area = " + l.AreaQuadrato());

        Console.ReadKey();
    }
}

public class Quadrato
{
    public float lato { get; set; }

    public float AreaQuadrato()
    {
        return lato * lato;

    }
}