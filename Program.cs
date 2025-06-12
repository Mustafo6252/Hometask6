
// //---------------------------------------  Task 1  -----------------------------------
//
//  using Homework6.Rectangle;
//  
//  internal class Program
//  {
//      private static void Main(string[] args)
//      {
//          Rectangle rectangle = new Rectangle();
//          Console.Write("Input the width: ");
//          rectangle.width=int.Parse(Console.ReadLine());
//          Console.Write("Input the height: ");
//          rectangle.height=int.Parse(Console.ReadLine());
//          
//          Console.WriteLine($"The area of rectangle: {rectangle.GetArea()}");
//          Console.WriteLine($"The perimetr of rectangle: {rectangle.GetPerimeter()}");
//      }
//  }
//  
// // ----------------------------------------  Task 2  -----------------------------------
//
//  using Homework6.Task2;
//
//  internal class Program
//  {
//      private static void Main(string[] args)
//      {
//          Task2 task2 = new Task2();
//          Console.Write("Enter Username: ");
//          string username = Console.ReadLine();
//          Console.Write("Enter Password: ");
//          string password = Console.ReadLine();
//          task2.Login(username, password);
//          
//          Console.WriteLine("Do you want to loging out? (y/n)");
//          int x = Console.Read();
//          if (x == 'y' || x == 'Y')
//              task2.Logout();
//          task2.GetFullInfo();
//      }
//  }

// // ---------------------------------------  Task3  --------------------------------------
//
// using Homework6.Author;
//
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Author author = new Author();
//         Console.Write("Input the name of author: ");
//         author.name = Console.ReadLine();
//         Console.Write("Input the age of author: ");
//         author.age = int.Parse(Console.ReadLine());
//         Console.Write("Input the Nationality of author: ");
//         author.nationality = Console.ReadLine();
//         
//         Console.WriteLine();
//         Console.WriteLine($"Author's name: {author.GetName()}");
//         Console.WriteLine($"Author's age: {author.GetAge()}");
//         Console.WriteLine($"Author's nationality: {author.GetNationality()}");
//         author.Introduce();
//     }
// }

// // ------------------------------------------  Task 4  -----------------------------------------
//
// using Homework6.Country;
//
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Country country = new Country(name: "Uzbekistan", capital: "Tashkent", population: 500, officialLanguage: "Uzbek tili");
//         Console.Write("Input the capital of country: ");
//         country.capital = Console.ReadLine();
//         Console.Write("Input the population of country: ");
//         country.population =int.Parse( Console.ReadLine());
//         Console.Write("Input the official language of country: ");
//         country.officialLanguage = Console.ReadLine();
//         
//         Console.WriteLine();
//         Console.WriteLine();
//         Console.WriteLine($"Name: {country.name}");
//         Console.WriteLine($"Capital: {country.capital}");
//         Console.WriteLine($"Population: {country.population}");
//         Console.WriteLine($"Official language: {country.officialLanguage}");
//         Console.WriteLine();
//         
//     }
// }