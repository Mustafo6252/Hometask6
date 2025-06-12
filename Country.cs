namespace Homework6.Country;

public class Country
{
    public string name;
    public string capital;
    public int population;
    public string officialLanguage;

    public Country(string name, string capital, int population, string officialLanguage)
    {
        this.name = name;
        this.capital = capital;
        this.population = population;
        this.officialLanguage = officialLanguage;
    }

    public void Setcapital(string capital)
    {
        this.capital = capital;
    }

    public string Getcapital()
    {
        return this.capital;
    }

    public void Setpopulation(int population)
    {
        this.population = population;
    }

    public int Getpopulation()
    {
        return this.population;
    }

    public void SetofficialLanguage(string officialLanguage)
    {
        this.officialLanguage = officialLanguage;
    }

    public string GetofficialLanguage()
    {
        return this.officialLanguage;
    }

}