﻿namespace Orders.Front.Models;

public class Order
{
    public int OrderNumber { set; get; }
    public string SendersCity { set; get; }
    public string SendersAddress { set; get; }
    public string RecipientsCity { set; get; }
    public string RecipientsAddress { set; get; }
    public double Weight { set; get; }
    public int PickupDay { set; get; }
    public int PickupMonth { set; get; }
    public int PickupYear { set; get; }
}