public class AutoGenSample
{
    public static void Main(string[] args)
    {
        List<string> col1 = new();
        List<string> col2 = new();
        List<int> col3 = new();
        
        List<string> names = new() { "Aleksandr", "Sergey", "Anton", "Ivan", "Petr", "Leonid", "Andrey", "Vasiliy" };
        List<string> surnames = new() { "Ivanov", "Petrov", "Sidorov", "Antonov", "Priluchniy", "Evstigneev", "Dvoreckov" };
        
        Random random = new();
        
        for (int i = 0; i < 50; i++)
        {
            col1.Add(names[random.Next(names.Count)]);
            col2.Add(surnames[random.Next(surnames.Count)]);
            col3.Add(random.Next(18, 66));
        }
        
        Dictionary<string, List<object>> data = new()
        {
            { "Name", col1.Cast<object>().ToList() },
            { "Surname", col2.Cast<object>().ToList() },
            { "Age", col3.Cast<object>().ToList() }
        };
        
        var df = new Dictionary<string, List<object>>();
        df = data;
        
        foreach (var item in df)
        {
            Console.WriteLine(item.Key + ": " + string.Join(", ", item.Value));
        }
    }
}