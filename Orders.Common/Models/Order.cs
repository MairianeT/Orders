namespace Orders.Common.Models;

public class Order
{
    public Guid OrderId { set; get; }
    public string SendersCity { set; get; }
    public string SendersAddress { set; get; }
    public string RecipientsCity { set; get; }
    public string RecipientsAddress { set; get; }
    public double Weight { set; get; }
    public DateOnly PickupDate { set; get; }
}