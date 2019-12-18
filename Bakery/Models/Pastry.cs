namespace Bakery.Models
{
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
