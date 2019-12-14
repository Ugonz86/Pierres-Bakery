using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Bread bread = new Bread();
      Pastry pastry = new Pastry();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Welcome to Pierre's Bakery! Best bread and pastries since 1900");
      Console.WriteLine("Bread Loaf e/a $5.00, Pastry e/a $2.00");
      Console.WriteLine("Today's Sale: Buy 2 bread loafs & get 1 free or buy 3 pastries for $5!");
      Console.WriteLine("Start your order by selecting a product. Type bread or pastry.");

      string productSelection = Console.ReadLine();
      if  (productSelection == "bread" || productSelection == "Bread" || productSelection == "BREAD")
      {
        AddBread(bread, pastry);
      }
      else if (productSelection == "pastry" || productSelection == "Pastry" || productSelection == "PASTRY")
      {
        AddPastry(pastry, bread);
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Wrong entry. Please try again.");
        Main();
      }
    }

    public static void AddBread(Bread bread, Pastry pastry)
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("Enter the # of bread loafs you would like to purchase:");

      int breadNo = int.Parse(Console.ReadLine());
      if (breadNo != 0)
      {
        bread.BreadInvoice(breadNo);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Bread Loaf Quantity: " + bread.Quantity + "." + " " + "Your bread total is: " + bread.Price + "$");

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Would you like to add anything else to your order? Type y to add pastries or n to checkout.");
        string addPastry = Console.ReadLine();
        if (addPastry == "y" || addPastry == "Y")
        {
          AddPastry(pastry, bread);
        }
        else
        {
          CheckOut(bread, pastry);
        }
      }
    }

    public static void AddPastry(Pastry pastry, Bread bread)
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("Enter the # of pastries you would like to purchase:");

      int pastryNo = int.Parse(Console.ReadLine());
      if (pastryNo != 0)
        {
          pastry.PastryInvoice(pastryNo);
          Console.ForegroundColor = ConsoleColor.DarkGreen;
          Console.WriteLine("Bread Loaf Quantity: " + pastry.Quantity + "." + " " + "Your pastry total is: " + pastry.Price + "$");

          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.WriteLine("Would you like to add anything else to your order? Type y to add bread or n to checkout.");
          string addBread = Console.ReadLine();
          if (addBread == "y" || addBread == "Y")
          {
            AddBread(bread, pastry);
          }
          else
          {
            CheckOut(bread, pastry);
          }
        }
    }

    static void CheckOut(Bread bread, Pastry pastry)
    {
      int checkOut = bread.Price + pastry.Price;
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Your entire purchase total is: " + checkOut + "$");
      Console.WriteLine("Thank you for visiting Pierre's Bakery. Come back soon!");
      Console.ResetColor();
    }
  }
}
