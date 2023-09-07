//  Дана целочисленная последовательность. 
//  Извлечь из нее все положительные числа, сохранив их исходный порядок следования.

int[] numbInt = new[] {12, -96, 85, 43, -15, 94, -562, 325, 140, -71, 342, -9, 888, -424};

int[] positiveInt = 
    (from numb in numbInt
    where numb>0
    select numb).ToArray();

foreach(int item in positiveInt)
{
    Console.WriteLine(item);
}    

// Дана целочисленная последовательность. 
// Извлечь из нее все нечетные числа, сохранив их исходный порядок следования.

int[] oddNumb = 
    (from numb in numbInt
    where numb % 2 != 0
    select numb).ToArray();

foreach(int item in oddNumb)
{
    Console.WriteLine(item);
}

// Дана целочисленная последовательность. Извлечь из нее все четные отрицательные числа.

int[] evenNegNumb = 
    (from numb in numbInt
    where numb<0 && numb%2==0
    select numb).ToArray();

foreach(int item in evenNegNumb)
{
    Console.WriteLine(item);
}

// Дана целочисленная последовательность. Извлечь из нее все положительные двузначные числа.

int[] doubledPosNumb = 
    (from numb in numbInt
    where numb>=10 && numb<=99
    select numb).ToArray();

foreach(int item in doubledPosNumb)
{
    Console.WriteLine(item);
}    

// Дана строковая последовательность (массив строк). 
// Извлечь только те строки, длина которых больше 5 (пяти) символов, 
// и которые начинаются на букву G.

string[] strArray = new[] {"Gentleman", "Hello", "Good", "Person", "Where", "German", "Language", "Namespace", "Example"};

string[] strG =
    (from str in strArray
    where str.StartsWith("G") && str.Length>5
    select str).ToArray();

foreach(string item in strG) Console.WriteLine(item);

// Дана строковая последовательность (массив строк). 
// Извлечь только те строки, длина которых не больше 5 (пяти) символов, 
// и которые заканчиваются на букву F.

string[] strSequence = new[] {"London", "Leaf", "Country", "Center", "Roof", "Direction", "Bulletproof"};

string[] strF =
    (from str in strSequence
    where str.EndsWith("f") && str.Length<=5
    select str).ToArray();

foreach(string item in strF) Console.WriteLine(item);    

// Дана последовательность непустых строк A. Получить последовательность символов, 
// каждый элемент которой является начальным символом соответствующей строки из A.

string[] strFilled =  new[] { "Hello", "World", "Alif", "Academy", "Car" };

string[] strFirstLetter = 
    (from str in strFilled
    select str.Substring(0,1)).ToArray();

foreach(string item in strFirstLetter) Console.WriteLine(item);

// Дана последовательность положительных целых чисел. 
// Обрабатывая только нечетные числа, получить последовательность их строковых представлений.

int[] arrayInt = new[] {12, 85, 43, 94, 562, 325, 140, 71, 342, 9, 888, 424};

IEnumerable<int> oddNumber =
    (from numb in arrayInt
    where numb%2 != 0
    select numb);

string[] strOddNumb = oddNumber.Select(i => i.ToString()).ToArray();
Console.WriteLine(String.Join(", ", strOddNumb));