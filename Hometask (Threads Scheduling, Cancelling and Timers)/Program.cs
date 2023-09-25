// 1. Установить приоритет потока с использованием свойства Thread.Priority в C#.

Thread thread1 = new(DisplayInfo) // Создаем экземпляр класса Thread, передаем метод DisplayInfo() как входной параметр
{
    Priority = ThreadPriority.BelowNormal //  Определяем приоритет потока через свойство Thread.Priority
};

thread1.Start(); // Запускаем поток через триггер метода Start()

static void DisplayInfo() // Создаем статичный метод (без возврата значения) DisplayInfo() для передачи в поток
{
    Console.WriteLine($"{Environment.CurrentManagedThreadId}: {Thread.CurrentThread.Priority} - This is message with below average importance...");
}

// 2. Отменить работу потоков с помощью CancellationToken в C#.

CancellationTokenSource cts = new(); // Создаем источник якоря (отправная точка для отмены управляемых потоков)

CancellationToken token = cts.Token; // Token = якорь (структура, тип значения, которая создает исключения путем замены значения True-False)

int i = 0; // Создаем переменную для дальнейшей инкрементации внутри цикла

while(true) // Создаем бесконечный цикл
{
    Console.WriteLine(token.IsCancellationRequested); // Определяем был ли запрос на отмену token

    i++; // Увеличиваем значение на 1 для передачи индекса в консоль
    Console.WriteLine($"Message #{i} is displayed!");

    if(Console.ReadKey().Key == ConsoleKey.Spacebar) // Задаем условие, при котором работа потоков отменится (нажатие пробела)
        cts.Cancel(); 
}

// 3. Прервать выполнение потоков в C# с использованием метода Abort.

Thread thread3 = new(flow3); // Создаем экземпляр класса Thread и передаем входной параметр flow3

thread3.Start(); // Запускаем поток
thread3.Abort(); // Приостанавливаем поток
Console.WriteLine($"Thread's status: {Thread.CurrentThread.ThreadState}"); // Выводим статус потока в консоль для проверки корректности прерывания (критерий = вызов ThreadAbortException)

static void flow3() // Создаем статичный метод flow3() который выводит числа от 10 до 1
{
    for(int i=10; i>0; i--)
    {
        Console.WriteLine($"Descending order from 10 to 1. Current value: {i}");
    }
}

// 4. Создать таймеры в C# для выполнения задач в определенные моменты времени.

using System.Timers;

System.Timers.Timer timer = new(2000); // Создаем экземпляр класса Timer и передаем значение 2 сек (для периодичности действий)
timer.Elapsed += Trigger; // Присваиваем метод когда таймер активируется
timer.AutoReset = true; // Многократный запуск
timer.Enabled = true; // Обеспечивает что метод Trigger будет многократно запускаться после вызова события Elapsed
timer.Start(); //  Непосредственно запускаем таймер

// Cоздаем метод Trigger() для запуска с определенной периодичностью
static void Trigger(object? sender, ElapsedEventArgs e) 
{
    Console.WriteLine("Timer activated, implementation started...");
}

// 5. Обработать исключения в управляемых потоках в C# с помощью блока try-catch.

Thread thread1 = new(MakeChanges); // Создаем экземпляр класса Thread и передаем метод MakeChanges() как входной параметр
thread1.Start(); // Запускаем поток

static void MakeChanges() // Создаем статичный метод (не возвращающий значения)
{
    try
    {
        Thread.Sleep(2000); // Приостановим выполнение потока на 2 секунды
        // Выводим идентификатор потока и статус его выполнения
        Console.WriteLine($"Actual thread ID: {Environment.CurrentManagedThreadId}\nCurrent thread status:{Thread.CurrentThread.ThreadState}");
    }
    catch (System.Exception ex) // Блок для фиксации и обработки исключения System.Exception
    {
        Console.WriteLine(ex.Message); // Вывод сообщения об исключении в консоль
    }
}


// 6. Задать максимально возможный приоритет потока в C# с использованием значения ThreadPriority.Highest.

Thread thread2 = new(ShowInfo) // Создаем экземпляр класса Thread, передаем метод ShowInfo() как входной параметр
{
    Priority = ThreadPriority.Highest //  Определяем приоритет потока через свойство Thread.Priority
};

thread2.Start(); // Запускаем поток через триггер метода Start()

static void ShowInfo() // Создаем статичный метод (без возврата значения) ShowInfo() для передачи в поток
{
    Console.WriteLine($"{Environment.CurrentManagedThreadId}: {Thread.CurrentThread.Priority} - This is message with HIGH importance, plz pay ATTENTION!!!!!");
}

// 7. Использовать CancellationTokenSource для отмены выполнения потоков в C#.

CancellationTokenSource cts = new(); // Создаем экземпляр источника якоря cts 

cts.Token.Register(() => Console.WriteLine("Termination is requested")); // Объявляем метод для токена Register() для создания делегата в случае отмены потока и создаем лямбда выражения для вывода в консоль

string str = "HelloWorld!"; 
int i = 0;

while(true) 
{
    cts.Token.ThrowIfCancellationRequested(); // Выкидываем исключение если якорю передалась отмена потока

    Console.WriteLine(str[i]);
    i++;
    
    // Задаем условие при котором поток будет приостановлен (нажатие ESC либо индекс символа превысит длину строки)

    if(Console.ReadKey().Key == ConsoleKey.Escape || i>=str.Length) 
        cts.Cancel();
}

// 8. Ограничить время выполнения потока с помощью CancellationToken и Task.Delay в C#.

    Task timer = Task.Run(async delegate {
        await Task.Delay(2000);
    });
 
    Console.WriteLine("Sleeping for 2 seconds...");

    CancellationTokenSource source = new();

     var t = Task.Run(async delegate
              {
                 await Task.Delay(TimeSpan.FromSeconds(3), source.Token);
                 return 51235125;
              });
    Console.WriteLine(t.Result);          
    source.Cancel();
    

// 9. Прекратить выполнение задач в таймере с помощью свойства Timer.Enabled в C#.

using System.Timers;

System.Timers.Timer timer = new(2000); // Создаем экземпляр класса Timer и передаем значение 2 сек (для периодичности действий)
timer.Elapsed += Trigger; // Присваиваем метод когда таймер активируется
timer.AutoReset = true; // Многократный запуск
timer.Enabled = false; // Обеспечивает что метод Trigger будет однократно запускаться после вызова события Elapsed
timer.Start(); //  Непосредственно запускаем таймер

// Cоздаем метод Trigger() для запуска с определенной периодичностью
static void Trigger(object? sender, ElapsedEventArgs e) 
{
    Console.WriteLine("Timer activated, implementation started...");
}