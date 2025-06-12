namespace Homework6.Task2;

public class Task2
{
    public string firstName="Mustafo";
    public string lastName="Ravshanov";
    public string username="Mustafo6252";
    public string password="r.m.a.6252";
    public bool isLoggedIn;

    public void Login(string Username, string Password)
    {
        if(Username==username&&Password==password) 
        {
            Console.WriteLine("User logged in successfully");
            isLoggedIn = true;
        }
        else
        {
            Console.WriteLine("Your username or password is incorrect ! ");
        }
    }

    public void Logout()
    {
        isLoggedIn = false;
    }
    
    public void GetFullInfo()
    {
        Console.WriteLine($"{firstName} {lastName} = {isLoggedIn}");
    }
}