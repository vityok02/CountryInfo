class Country
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public string Language { get; set; }
    public int CountryId { get; set; }
    public DateTime Time { get; set; }
    public void Print()
    {
        Console.WriteLine($"Country:\t {Name}");
        Console.WriteLine($"Capital:\t {Capital}");
        Console.WriteLine($"Language:\t {Language}");
        Console.WriteLine($"Id:\t \t {CountryId}");
        Console.WriteLine($"Time:\t  \t {Time:HH:mm:ss}");
        Console.WriteLine("==============================");
    }   
}

