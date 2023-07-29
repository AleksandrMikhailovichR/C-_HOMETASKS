//  - Переведите проект CRM на net7. 

//  - Сделайте обязательными те свойства классов Order и Client, которые считаете обязательными (выбирайте сами).

//  - Используйте init-сеттер для всех свойств класса Order и Client.

//  - Добавьте валидацию значений свойств класса Order и Client на уровне геттеров и сеттеров.

class Client
{
    public required string? _firstName;
    public required string? _surName;

    public string _middleName;

    public required string? _age;

    public required string? _passportNumber;

    public string _maritalStatus;

    public string FirstName
    {
        get => _firstName ?? string.Empty;
        init => _firstName = value is {Length: >0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    
    public string SurName
    {
        get => _surName?? string.Empty;
        init => _surName = value is {Length: >0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
        
    public string MiddleName
    {
        get => _middleName;
        init => _middleName = value;
    }
    public string Age
    {
        get => _age ?? string.Empty;
        init => _age = value is {Length: >0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string PassportNumber
    {
        get => _passportNumber ?? string.Empty;
        init => _passportNumber = value is {Length: >0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string MaritalStatus
    {
        get => _maritalStatus;
        init => _maritalStatus = value;
    }
}

class Order
{
    public required string? _id;
    public string _description;

    public required string? _price;

    public required string? _date;
    public string _deliveryType;

    public string Id
    {
        get => _id ?? string.Empty;
        init => _id = value is {Length: >0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string Description
    {
        get => _description;
        init => _description = value;
    }

    public string Price
    {
        get => _price ?? string.Empty;
        init => _price = value is {Length: >0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string Date
    {
        get => _date ?? string.Empty;
        init => _date = value is {Length: >0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string DeliveryType
    {
        get => _deliveryType;
        init => _deliveryType = value;
    }
}