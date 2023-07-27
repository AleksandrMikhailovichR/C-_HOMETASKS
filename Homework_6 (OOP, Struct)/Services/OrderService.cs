public sealed class OrderService
{
    public Order CreateOrder(
        string id,
        string desc,
        int pr,
        string dt,
        string DA,
        int DT
    )
    {
        // TODO: Validate input parameters.
        return new()
        {
            Id = id,
            Description = desc,
            Price = pr,
            Date = dt,
            DeliveryAddress = DA,
            DeliveryTypе = DT
        };
    }

}