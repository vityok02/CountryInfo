string country = Console.ReadLine();

Country ukraine = new()
{
    Name = "Ukraine",
    Capital = "Kyiv",
    Language = "Ukraining",
    CountryId = +380,
    Time = DateTime.UtcNow.AddHours(3)
};
Country poland = new()
{
    Name = "Poland",
    Capital = "Warsaw",
    Language = "Polish",
    CountryId = +48,
    Time = DateTime.UtcNow.AddHours(2)
};
ukraine.Print();
