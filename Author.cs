namespace Homework6.Author;

public class Author
{
    public string name;
    public int age;
    public string nationality;

    public Author()
    {
    }

    public Author(string name, int age):this()
    {
        this.name = name;
        this.age = age;
    }

    public Author(string name, int age, string nationality) : this(name, age)
    {
        this.nationality = nationality;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetNationality()
    {
        return nationality;
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {name}, and I am {age} years old. I am from {nationality}.");
    }

    public void CelebrateBirthday()
    {
        age+=1;
    }
}