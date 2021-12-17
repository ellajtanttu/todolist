using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}

// ----------------------------------
// using System; // directive - tells it what code it needs in order to function.
// using System.Collections.Generic; // if using list objects
// using ToDoList.Models;

// class Program//class
// {

//   static void Main()
//   {
//     Console.WriteLine("MAIN MENU");
//     Console.WriteLine("Would you like to add an item to your To Do List? ['Y' for yes, 'Enter' for no]");
//     string addItemAnswer = Console.ReadLine();
//     if (addItemAnswer == "Y" || addItemAnswer == "y" )
//     {
//       Console.WriteLine("Add something to your to do list:");
//       string userDescription = Console.ReadLine();
//       new Item(userDescription);
//       Main();
//     }
//     else
//     {
//       Console.WriteLine("Would you like to see your full To Do List? ['Y' for yes, 'Enter' for no]");
//       string fullListAnswer = Console.ReadLine();
//       if (fullListAnswer == "Y" || fullListAnswer == "y" )
//       {
//         if (Item.GetAll().Count == 0)
//         {
//           Console.WriteLine("Your list is empty! Please add an item first.");
//           Main();
//         }
//         else
//         {
//           foreach (Item thisItem in Item.GetAll())
//           {
//             Console.WriteLine(thisItem.Description);
//           }
//           Main();
//         }
//       }
//       else
//       {
//         Console.WriteLine("Would you like to clear your To Do List? ['Y' for yes, 'Enter' for no]");
//         string clearAnswer = Console.ReadLine();
//         if (clearAnswer == "Y" || clearAnswer == "y" )
//         {
//           Item.ClearAll();
//           Main();
//         }
//         else
//         {
//           Main();
//         }
//       }
//     }

//   }
// }