// 1. Напишите программу, которая создает два потока. Первый поток должен выводить все числа от 1 до 100, 
// а второй поток - все числа от 101 до 200.

Thread thread1 = new(flow1);
Thread thread2 = new(flow2);

thread1.Start();
thread2.Start();

static void flow1()
{
    for(int i = 1; i < 101; i++)
    {
        Console.WriteLine($"Thread #1 shows: {i}");
    }
}

static void flow2()
{
    for(int i = 101; i < 201; i++)
    {
        Console.WriteLine($"Thread #2 shows: {i}");
    }
}


// 2. Напишите программу, которая создает два потока. Первый поток должен выводить все четные числа от 0 до 100, 
// а второй поток - все нечетные числа от 1 до 99.


Thread thread3 = new(flow3);
Thread thread4 = new(flow4);

thread3.Start();
thread4.Start();

static void flow3()
{
    for(int i = 0; i < 101; i+=2)
    {
        Console.WriteLine($"Thread #3 shows: {i}");
    }
}

static void flow4()
{
    for(int i = 1; i < 100; i+=2)
    {
        Console.WriteLine($"Thread #4 shows: {i}");
    }
}


// 3. Напишите программу, которая создает три потока. Первый поток должен выводить все числа от 1 до 33, 
// второй поток - от 34 до 66, а третий поток - от 67 до 100.

Thread thread5 = new(flow5);
Thread thread6 = new(flow6);
Thread thread7 = new(flow7);

thread5.Start();
thread6.Start();
thread7.Start();

static void flow5()
{
    for(int i = 1; i < 34; i++)
    {
        Console.WriteLine($"Thread #5 shows: {i}");
    }
}

static void flow6()
{
    for(int i = 34; i < 67; i++)
    {
        Console.WriteLine($"Thread #6 shows: {i}");
    }
}

static void flow7()
{
    for(int i = 67; i < 101; i++)
    {
        Console.WriteLine($"Thread #7 shows: {i}");
    }
}


// 4. Напишите программу, которая создает два потока. Первый поток должен перебирать и выводить все
//  буквы английского алфавита (от A до M), а второй поток - все остальные буквы (от N до Z).

Thread thread8 = new(flow8);
Thread thread9 = new(flow9);

thread8.Start();
thread9.Start();

static void flow8()
{
    for(int i = 65; i <= 77; i++)
    {
        Console.WriteLine($"Thread #8 shows: {(char)i}");
    }
}

static void flow9()
{
    for(int i = 78; i <= 90; i++)
    {
        Console.WriteLine($"Thread #9 shows: {(char)i}");
    }
}

// 5. Напишите программу, которая создает два потока. Первый поток должен выводить все числа, кратные 3, 
// от 1 до 100, а второй поток - все числа, кратные 5, от 1 до 100.

Thread thread10 = new(flow10);
Thread thread11 = new(flow11);

thread10.Start();
thread11.Start();

static void flow10()
{
    for(int i = 3; i <= 100; i+=3)
    {
        Console.WriteLine($"Thread #10 shows: {i}");
    }
}

static void flow11()
{
    for(int i = 5; i <= 100; i+=5)
    {
        Console.WriteLine($"Thread #11 shows: {i}");
    }
}

// 6. Напишите программу, которая создает два потока. Первый поток должен выводить все простые числа от 1 до 100,
// а второй поток - все составные числа от 1 до 100.

Thread thread12 = new(flow12);
Thread thread13 = new(flow13);

thread12.Start();
thread13.Start();

static void flow12()
{
    for(int i = 2; i <= 100; i++)
    {
        int k = 0;
        for(int j = 1; j <= i; j++)
        {
            if(i%j==0) k++;            
        }
        if(k==2) Console.WriteLine($"Thread #12 shows: {i}");
    }
}

static void flow13()
{
        for(int i = 2; i <= 100; i++)
    {
        int k = 0;
        for(int j = 1; j <= i; j++)
        {
            if(i%j==0) k++;            
        }
        if(k!=2) Console.WriteLine($"Thread #13 shows: {i}");
    }
}

// 7. Напишите программу, которая создает два потока. Первый поток должен считать и вывести сумму всех чисел 
// от 1 до 100, а второй поток - произведение всех чисел от 1 до 100.

Thread thread14 = new(flow14);
Thread thread15 = new(flow15);

thread14.Start();
thread15.Start();

static void flow14()
{
    int sum = 0; 
    for(int i = 1; i <= 100; i++) sum+=i;
    Console.WriteLine($"Thread #14 shows: {sum}"); 
}

static void flow15()
{
    int multiply = 1; 
    for(int i = 1; i <= 100; i++) multiply*=i;
    Console.WriteLine($"Thread #15 shows: {multiply}"); 
}

// 8. Напишите программу, которая создает два потока. Первый поток должен выводить все числа, которые делятся 
// на 3 или на 5, от 1 до 100, а второй поток - все числа, которые не делятся ни на 3, ни на 5.

Thread thread16 = new(flow16);
Thread thread17 = new(flow17);

thread16.Start();
thread17.Start();

static void flow16()
{
    for(int i = 1; i <= 100; i++)
    {
        if(i%3==0 || i%5==0) Console.WriteLine($"Thread #16 shows: {i}"); 
    }    
};

static void flow17()
{
    for(int i = 1; i <= 100; i++)
    {
        if(i%3!=0 && i%5!=0) Console.WriteLine($"Thread #17 shows: {i}"); 
    }    
}

// 9. Напишите программу, которая создает два потока. Первый поток должен выводить все числа от 1 до 50, 
// а второй поток - все числа от 51 до 100, но в обратном порядке.

Thread thread18 = new(flow18);
Thread thread19 = new(flow19);

thread18.Start();
thread19.Start();

static void flow18()
{
    for(int i = 1; i <= 50; i++)
    {
        Console.WriteLine($"Thread #18 shows: {i}"); 
    }    
};

static void flow19()
{
    for(int i = 100; i >= 51; i--)
    {
        Console.WriteLine($"Thread #19 shows: {i}"); 
    }    
}

// 10. Напишите программу, которая создает два потока. Первый поток должен выводить все числа от 1 до 100, 
// а второй поток - выводить квадраты этих чисел.

Thread thread20 = new(flow20);
Thread thread21 = new(flow21);

thread20.Start();
thread21.Start();

static void flow20()
{
    for(int i = 1; i <= 100; i++)
    {
        Console.WriteLine($"Thread #20 shows: {i}"); 
    }    
};

static void flow21()
{
    for(int i = 1; i <= 100; i++)
    {
        Console.WriteLine($"Thread #21 shows: {i*i}"); 
    }    
}