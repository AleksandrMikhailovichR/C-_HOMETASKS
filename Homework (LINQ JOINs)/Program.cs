 // Дана целочисленная последовательность. Извлечь из нее все положительные двузначные числа, 
 // отсортировав их по возрастанию.

int[] numbInt = new[] {12, -96, 85, 43, -15, 94, -562, 325, 140, -71, 342, -9, 888, -424};

int[] positive2DigitsNumb = 
    (from numb in numbInt
    where numb >= 10 && numb <= 99
    select numb).ToArray();

var sortAsc = positive2DigitsNumb.OrderBy(x => x);

foreach(int item in sortAsc) Console.WriteLine(item);


 // Дана строковая последовательность. Строки последовательности содержат только заглавные 
 // буквы латинского алфавита. Отсортировать последовательность по возрастанию длин строк, 
 // а строки одинаковой длины — в лексикографическом порядке по убыванию.

string[] strSequence = new[] {"GFEWF", "ADWEFM", "EFHEW", "MDSFKVNI", "XED", "WEFGW", "YTRDQ", "OPD" };

string[] strQuery = 
    (from str in strSequence
    orderby str.Length, str ascending
    select str).ToArray();

foreach(string str in strQuery) Console.WriteLine(str);


//  Дано целое число K (> 0) и строковая последовательность A. Из элементов A, предшествующих элементу с порядковым
//  номером K, извлечь те строки, которые имеют нечетную длину и начинаются с заглавной латинской буквы, 
//  изменив порядок следования извлеченных строк на обратный.

Console.Write("Введите целое число К (>0): ");
int K = int.Parse(Console.ReadLine());

string[] A = new[] {"Gentleman", "Hello", "good", "person", "Where", "German", "language", "Name", "Example"};

string[] strQuery2 = 
    (from str in A
    where Array.IndexOf(A, str) < K && 
    (str.Length%2 != 0 && char.IsUpper(str[0]))
    orderby str descending
    select str).ToArray();

foreach(string str in strQuery2) Console.WriteLine(str);


 // Дана целочисленная последовательность. Обрабатывая только положительные числа, 
 // получить последовательность их последних цифр и удалить в полученной последовательности
 // все вхождения одинаковых цифр, кроме первого. 
 // Порядок полученных цифр должен соответствовать порядку исходных чисел.

int[] numbInt2 = new[] {12, -96, 85, 43, -15, 94, -562, 325, 140, -71, 342, -9, 888, -424};

int[] positiveNumb = 
    (from numb in numbInt2
    where numb>0
    select numb).ToArray();

var sortedUniqueDigit = positiveNumb.Select(x => x%10).Distinct();    

foreach(int numb in sortedUniqueDigit) Console.WriteLine(numb);


 // Дана последовательность непустых строк. Получить последовательность символов, 
 // которая определяется следующим образом: если соответствующая строка исходной последовательности 
 // имеет нечетную длину, то в качестве символа берется первый символ этой строки; 
 // в противном случае берется последний символ строки. Отсортировать полученные символы по убыванию их кодов.

string[] strSequence2 = new[] {"London", "Leaf", "Country", "Center", "Roof", "Direction", "Bulletproof"};

var result = strSequence2
.Select(x => x.Length%2 != 0 ? x[0] : x[x.Length-1])
.OrderByDescending(x => x);

foreach(char item in result) Console.WriteLine(item);


 // Даны целые числа K1 и K2 и целочисленные последовательности A и B. Получить последовательность, 
 // содержащую все числа из A, большие K1, и все числа из B, меньшие K2. Отсортировать полученную 
 // последовательность по возрастанию. 

int K1 = 20;
int K2 = 30;

int[] AA = new[] {12, -96, 85, 43, -15, 94, -562, 325, 140, -71, 342, -9, 888, -424};
int[] BB = new[] {309, 751, -99, 5, 18, -72, 34, 98, 401, -449, -763, 573, 14, 19};

var resultFinal = 
    (from numb in AA
    where numb>K1
    select numb).ToArray()
    .Union
        (from numb in BB
        where numb<K2
        select numb
        );

var sortedResult = resultFinal.OrderBy(x => x);

foreach(var item in sortedResult) Console.WriteLine(item);