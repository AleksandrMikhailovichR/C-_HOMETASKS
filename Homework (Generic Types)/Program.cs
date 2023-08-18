//////// GENERAL PRACTICE ////////

// // Generic Types in Method

// int[] arrayInt = {11, 4, 321, 5431, 8192, 219, 90};
// string[] arrayStr = {"My", "name", "is", "Alex"};
// char[] arrayCh = {'!', ')', '%', '#', '&'};

// static void ReversedArrayOrder<T>(T[] Array_)
// {
//     for(int i = Array_.Length-1; i>=0; i--) Console.WriteLine(Array_[i]);
// }

// ReversedArrayOrder(arrayInt);
// ReversedArrayOrder(arrayStr);
// ReversedArrayOrder(arrayCh);

// // Generic Types in Class

// Pet<uint> pet1 = new(12390141, "Boris", "Cat", 4, "Meeeowwww");
// Pet<string> pet2 = new("34f1wdz10vq", "Sharik", "Dog", 3, "Gaf-gaf");
// pet1.DisplayPetInfo();
// pet2.DisplayPetInfo();

// class Pet<T>
// {
//     public T? VeterinarId { get; set; }
//     public string? Nickname { get; set; }
//     public string? Category { get; set; }

//     public short? Age { get; set; }
//     public string? Sound { get; set; }

//     public Pet(T _vetId, string _nickName, string _category, short _age, string _sound)
//     {
//         VeterinarId = _vetId;
//         Nickname = _nickName;
//         Category = _category; 
//         Age  = _age;
//         Sound = _sound;
//     }

//     public void DisplayPetInfo()
//     {
//         Console.WriteLine($" Pet's identifier is {VeterinarId}\n Nickname is {Nickname}\n Animal type is {Category}\n Age is {Age}\n It makes sound '{Sound}' ");
//     }
// }

// // Generic Type Constraints


// using System.ComponentModel.DataAnnotations;
// using System.Reflection.Metadata.Ecma335;

// abstract class Planet<T>
//     where T: SputnikInfo, new()
// {
//     public string? Name { get; set; }
//     public T? Sputnik { get; set; }
//     public long Weight { get; set; }
//     public short AverageTemperature { get; set; }  
//     public bool IsLivable { get; set; }
//     public string? Surface {get; set;}

// }   

// class SputnikInfo
// {
//     public string _name;
//     public long _radius;
//     public short _gravity;

//     public SputnikInfo(string name, long radius, short gravity)
//     {
//         _name = name;
//         _radius = radius;
//         _gravity = gravity;

//     }
// }

// class Survey<I>
//     where I: IGoogleForms
// {

// }

// public interface IGoogleForms
// {
//     const int minQuestions = 3;
//     static int maxQuestions = 20;
//     static string backgroundColor = "purple";
//     string SurveyName { get; set; }
//     void Click() => Console.WriteLine("The option is chosen and saved!");
// }

// class Shape
// {
//     public void Area<A>()
//         where A: struct 
//     {

//     }
        
// }
// public struct Triangle
// {
//     public short SidesNumber;
//     public int[] SidesValue;
//     public Triangle(short sidesN, int[] sidesV)
//     {
//         this.SidesNumber = sidesN;
//         this.SidesValue = sidesV;
//     }

//     public bool DoesTriangleExist()
//     {
//        if(SidesNumber is not 3 || SidesValue.Length is not 3) return false;
//        else 
//        {
//             if(SidesValue[0]+SidesValue[1]>SidesValue[2] && SidesValue[1]+SidesValue[2]>SidesValue[0] && SidesValue[0]+SidesValue[2]>SidesValue[1])
//             {
//                 return true;
//             }
//             else return false;
//        }  
//      }
// }
