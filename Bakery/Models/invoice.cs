using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }

    public Bread()
    {
      Price = 0;
    }
    public void BreadInvoice(int breadNo)
    {
      Price = breadNo * 5 - 5 * (breadNo/3);
    }
  }

  public class Pastry
  {
    public int Price { get; set; }

    public Pastry()
    {
      Price = 0;
    }
    public void PastryInvoice(int pastryNo)
    {
      Price = pastryNo * 2 -1 * (pastryNo/3);
    }
  }
}
