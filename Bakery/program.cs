using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Bread bread = new Bread();
      Pastry pastry = new Pastry();

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread Loaf Price: $5.00, Pastry Price: $2.00");
      Console.WriteLine("Today's Special: Buy 2 bread loafs & get 1 free or buy 3 pastries for $5!");
      Console.WriteLine("Start your order by selecting a product. Type bread or pastry");
      string productSelection = Console.ReadLine();
      if  (productSelection == "bread" || productSelection == "Bread" || productSelection == "BREAD")
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter the # of bread loafs you would like to purchase:");
        int breadNo = int.Parse(Console.ReadLine());
        if (breadNo != 0)
        {
          bread.BreadInvoice(breadNo);
          Console.WriteLine("Bread Loaf Quantity: " + breadNo + "." + " " + "Your bread total is: " + bread.Price + "$");

          // Console.WriteLine("Would you like to add pastries to your order? y/n");
          // string addPastry = Console.ReadLine();
          // if (addPastry == "y" || addPastry == "Y")
          // {
          //
          // }
        }

        else if (productSelection == "pastry" || productSelection == "Pastry" || productSelection == "PASTRY")
        {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter the # of pastries you would like to purchase:");
        int pastryNo = int.Parse(Console.ReadLine());
        if (pastryNo != 0)
          {
            pastry.PastryInvoice(pastryNo);
            Console.WriteLine("Bread Loaf Quantity: " + pastryNo + "." + " " + "Your pastry total is: " + pastry.Price + "$");

            // Console.WriteLine("Would you like to add bread to your order? y/n");
            // string addBread = Console.ReadLine();
            // if (addBread == "y" || addBread == "Y")
            //
            // {
            //   CheckOut();
            // }
          }
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Wrong entry. Please try again.");
        }
      }
      int checkOut = bread.Price + pastry.Price;
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Your entire purchase total is: " + checkOut + "$");
      Console.WriteLine("Thank you for visiting Pierre's Bakery. Come back soon!");
      Console.ResetColor();
    }
  }
}
