using Crm.DataAccess;

public sealed class OrderService
{
    public Order CreateOrder(
        long id,
        string desc,
        int pr,
        string dt,
        string DA,
        int DT,
        OrderState orderState
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
            DeliveryTypе = DT,
            OrderState = orderState
        };
    }

}