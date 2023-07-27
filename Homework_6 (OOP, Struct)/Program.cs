//  - Разработайте две readonly struct сущности: ClientInfo и OrderInfo.
//  - Используйте две данные сущности для передачи в метод CreateClient и CreateOrder.

ClientInfo clientInfo = new()
{
    FirstName = "Ivan",
    LastName = "Ivanov",
    MiddleName = "Ivanovich",
    Age = 25,
    PassportNumber = "34906514",
    Gender = "Male"
};

ClientService clientService = new();
CreateClient();

void CreateClient()
{
    Console.WriteLine($"FirstName = {clientInfo.FirstName}");
    Console.WriteLine($"LastName = {clientInfo.LastName}");
    Console.WriteLine($"MiddleName = {clientInfo.MiddleName}");
    Console.WriteLine($"Age = {clientInfo.Age}");
    Console.WriteLine($"PassportNumber = {clientInfo.PassportNumber}");
    Console.WriteLine($"Gender = {clientInfo.Gender}");
    
}



OrderInfo orderInfo = new()
{
    Id = "12344045",
    Description = "Small box of candys",
    Price = 30,
    Date = "10/08/2023",
    DeliveryTypе = 0,
    DeliveryAddress = "Rudaki street, house №11"
};

OrderService orderService = new();
CreateOrder();

void CreateOrder()
{
    Console.WriteLine($"Id = {orderInfo.Id}");
    Console.WriteLine($"Description = {orderInfo.Description}");
    Console.WriteLine($"Price = {orderInfo.Price}");
    Console.WriteLine($"Date = {orderInfo.Date}");
    Console.WriteLine($"DeliveryType = {orderInfo.DeliveryTypе}");
    Console.WriteLine($"DeliveryAddress = {orderInfo.DeliveryAddress}");
}

public readonly struct ClientInfo
{
    public readonly string FirstName { get; init; }
    public readonly string LastName { get; init; }
    public readonly string MiddleName { get; init; }
    public readonly short Age { get; init; }
    public readonly string PassportNumber { get; init; }
    public readonly string Gender { get; init; }
}


public readonly struct OrderInfo
{
    public readonly string Id { get; init; }

    public readonly string Description { get; init; }

    public readonly int Price { get; init; }

    public readonly string Date { get; init; }

    public readonly DeliveryType DeliveryTypе { get; init; }
    
    public readonly string DeliveryAddress { get; init; }

    public enum DeliveryType
    {
        Express = 0,
        Standard = 1,
        Free = 2
        
    }
}


