using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

public class Program
{
	public static void Main()
	{
		
	}



// // S (SRP) - Single Responsibility Principle 
// // У каждой сущности должна быть своя задача/ответственность, либо 1 причина, по которой идут изменения.
// // То есть у каждого модуля есть своя причина для изменения или расширения.

//     class Car
//     {
//         public string Model { get;}
//         public int ProductionDate { get; }
//         public int Price { get;}
//         public Car(string model, int productionDate, int price)
//         {
//             Model = model;
//             ProductionDate = productionDate;
//             Price = price;
//         }
//     }
 
//     class InfoTyping
//     {
//         public void InputInfo()
//         {
//             Console.WriteLine("Type car model: ");
//             string? model = Console.ReadLine();
//             Console.WriteLine("Type car production date: ");
//             string? productionDate = Console.ReadLine();
//             Console.WriteLine("Type car price: ");
//             string? price = Console.ReadLine();
//         }
//     }
    
// }

// class Publish
// {
//     public void Print(Letter letter)
//     {
//         Console.WriteLine(letter.Text);
//     }
// }

// // O (OCP) - Open-Closed Principle
// // Каждая сущность - класс/метод/тд. - должна быть открыта для расширения но закрыта для модификации.

//     abstract class Shape
//     {
//         public string? ShapeName { get; set; }
//         public void Draw();
//     }

//     class Triangle: Shape
//     {
//         private string? _shapeName;
//         public override string ShapeName
//         {
//             get => _shapeName ?? string.Empty;
//             set => _shapeName = value;
//         }

//         public override void Draw()
//         {
//             System.Console.WriteLine("Drawing triangle!");
//         }
//     }

//     class Square: Shape
//     {
//         private string? _shapeName;
//         public override string ShapeName
//         {
//             get => _shapeName ?? string.Empty;
//             set => _shapeName = value;
//         }

//         public override void Draw()
//         {
//             System.Console.WriteLine("Drawing square!");
//         }

//     }


// // L (LSP) - Liskov Substitution Principle
// // Поведение-кодовая база дочернего элемента не должно отличаться от родительского элемента.
// // Дочерние элементы должны иметь возможность заменять родительские без ущерба для кода.

//     public class Employee
//     {
//         public string? Salary {get; set;}
//         public int WorkDuration {get; set;}
//     }

//     class Senior: Employee
//     {
//         new string Salary => "20.000";
//         new int WorkDuration => 5;        
//     }

//     class Middle: Employee
//     {
//         new string Salary => "15.000";
//         new int WorkDuration => 3;        
//     }

//         class Junior: Employee
//     {
//         new string Salary => "10.000";
//         new int WorkDuration => 1;        
//     }




// // I (ISP) - Interface Segregation Principle
// // Сущности должны зависеть только от используемых методов (необходимо разделять "крупный" интерфейс на частные случаи).

// Console.WriteLine("Input type of payment: ");
// string typeOfPayment = Console.ReadLine();
// IPayment payment = null;
// if(typeOfPayment == "Cash") 
//     payment = new Cash();
// else if (typeOfPayment == "Card")
//     payment = new Card();
// else if (typeOfPayment == "Cheque")
//     payment = new Cheque();    
// else Console.WriteLine("Double-check the filled info and try again!");    


// payment.PaymentType();

// interface IPayment
// {
//     public void PaymentType();
// }

// class Cash: IPayment
// {
//     public void PaymentType()
//     {
//        Console.WriteLine("Pay your products in cash!");
//     }
// }

// class Card: IPayment
// {
//     public void PaymentType()
//     {
//         Console.WriteLine("Pay your products by card!");
//     }
// }

// class Cheque: IPayment
// {
//     public void PaymentType()
//     {
//         Console.WriteLine("Pay your products by cheque!");
//     }
// }

// // D (DIP) - Dependency Inversion Principle
// // Имплементация метода должна зависеть от абстракции, но не от реализации.
// // Абстракция позволяет создавать несколько реализаций (изменять поведение приложения в процессе runtime).

// IMailer mailer = new SmsMailer();

// SpamMessageMailer spamMessageMailer = new SpamMessageMailer(mailer);
// spamMessageMailer.StartSpamming();


// public class SpamMessageMailer
// {
//     private readonly IMailer _mailer;
//     public SpamMessageMailer (IMailer mailer)
//     {
//         _mailer = mailer;
//     }
//     public void StartSpamming()
//     {
//         for(int i=0; i<1000; i++)
//         {
//             _mailer.Mail("SPAM MESSAGE!");
//         }
//     }
// }

// public interface IMailer
// {
//     public void Mail(string message);
// }

// public class SmsMailer: IMailer
// {
//     public void Mail(string message)
//     {
//         Console.WriteLine($"Mailing message via SMS: {message}");
//     }
// }

// public class EmailMailer: IMailer
// {
//     public void Mail(string message)
//     {
//         Console.WriteLine($"Mailing message via E-mail: {message}");
//     }
// }

}
