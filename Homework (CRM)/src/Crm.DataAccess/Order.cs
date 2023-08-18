using Crm.DataAccess;

public sealed class Order


{
    public long Id { get; set; }

    public string Description { get; set; }

    public int Price { get; set; }

    public string Date { get; set; }

    public int DeliveryTypе { get; set; }
    
    public string DeliveryAddress { get; set; }

    public OrderState OrderState { get; set; }
}