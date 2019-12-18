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
}