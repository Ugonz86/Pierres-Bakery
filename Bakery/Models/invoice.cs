using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Bread()
    {
      Price = 0;
      Quantity = 0;
    }
    public void BreadInvoice(int breadNo)
    {
      Quantity = Quantity + breadNo;
      Price = Quantity * 5 - 5 * (Quantity/3);
    }
  }

  public class Pastry
  {
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Pastry()
    {
      Price = 0;
      Quantity = 0;
    }
    public void PastryInvoice(int pastryNo)
    {
      Quantity = Quantity + pastryNo;
      Price = Quantity * 2 -1 * (Quantity/3);
    }
  }
}
