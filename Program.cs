internal class Program
{
    public static void Main()
    {
        List<Osoba> osobe = new();

        do
        {
            Osoba o = new();
            Console.Write("Unesite ime: ");
            o._name = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            o._surname = Console.ReadLine();

            osobe.Add(o);

            foreach (Osoba neko in osobe)
            {
                Console.WriteLine($"{neko._name} {neko._surname}");
            }
        } while (true);
    }
}

internal class Osoba
{
    public string _name;
    public string _surname;

    public void JaviSe()
    {
        Console.WriteLine($"Hej, ja sam {_name} :D");
    }
}