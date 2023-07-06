//See https://aka.ms/new-console-template for more information

using System;
namespace Iamprogrammer;
class Program
{
    enum DayOfWeekend
    { 
    Sunday = 0,
    Monday = 1,
    Tuesday = 2,
    Thursday = 3
    }


    //Pierwsze kroki w programowaniu językiem C#
    static void Main(string[] args)
    {
        int myIntegers = 5;
        myIntegers = 6;

        int myIntegers2;
        myIntegers2 = 6 + 6;
        int Sum = myIntegers - myIntegers2;
        double myDouble = 2.5;
        string myString = "I am programmer";
        bool myTrue = true;
        bool myTrue2 = false;
        char myCharacter = 'c';
        double myRemeinOperator = 10 % 4;

        Console.WriteLine("The sentence that {0} is {1,-5}.", myString, myTrue);
        Console.WriteLine("My mark for programming is " + myIntegers);
        Console.WriteLine("Two of six equals "+myIntegers2);
        Console.WriteLine("-12:2,5= {0}",Sum / myDouble);
        Console.WriteLine("the rest of 10:4="+myRemeinOperator);

        //Add to variable
        double mySum = 3;
        mySum = mySum + 5;
        mySum += 2;
        Console.WriteLine("The value of mySum plus 7 equals {0}.", mySum);

        mySum++;
        Console.WriteLine("One more for mySum is {0}.", mySum);

        int A = 4;
        int B = A++;
        Console.WriteLine("The value of A is 4 and of the B is {1}.", A, B);

        int C = 4;
        int D = ++C;
        Console.WriteLine("The value of C is 4 and the of the D is {1}", C, D);

        int myInt = 3;
        int myInt2 = myInt++;
        Console.WriteLine(myInt2);


        //Bool Data Type

        bool myBool = 5 >= 6;
        bool myBool2 = -5 >= -6;
        Console.WriteLine("Sentence that 5 is bigger or equal 6 is {0}", myBool);
        Console.WriteLine(myBool2);

        int hoursWorked = 160;
        bool extraWorkTime = hoursWorked > 160;
        Console.WriteLine("Does employee get overtime? {0}", extraWorkTime);

        //Character Data Type
        char myChar = 'A';
        char myChar1 = '\n';
        char myChar2 = '\a';
        char myChar3 = 'B';
        Console.WriteLine(myChar);
        Console.WriteLine(myChar1);
        Console.WriteLine(myChar2);
        Console.WriteLine();
        Console.WriteLine(myChar3);

        //String

        string name1 = "\"Przemek\"";
        string name2 = "\"Slawek\"";
        string name3 = "\"Przemek\"";
        bool namesEqual = name1 == name2;
        bool nameEqual2 = string.Equals(name1, name3);
        int nameEqual3 = string.Compare(name1, name2);
        int nameEqual4 = string.Compare(name1, name3);
        int nameEqual5 = string.Compare(name2, name1);
        int nameEqual6 = name1.CompareTo(name2);

        Console.WriteLine("name 1 is {0}\nname 2 is {1}\nname 3 is {2}", name1, name2, name3);
        Console.WriteLine("Are name 1 and 2 equal? {0}", namesEqual);
        Console.WriteLine("Are name 1 and 3 equal? {0}", nameEqual2);
        Console.WriteLine("Are name 1 and 2 equal? {0}", nameEqual3);
        Console.WriteLine("Are name 1 and 3 equal? {0}", nameEqual4);
        Console.WriteLine("Are name 2 and 1 equal? {0}", nameEqual5);
        Console.WriteLine("Are name 1 and 2 equal? {0}", nameEqual6);
        Console.WriteLine("{0} has {1} characters", name1, name1.Length);
        Console.WriteLine("{0} has {1} characters", name2, name2.Length);

        string firstCharName = name1.Substring(1, 1);
        Console.WriteLine("First letter of Przemek is {0}", firstCharName);

        string middleSectionOfName = name1.Substring(2, 5);
        Console.WriteLine("First letters of Przemek is {0}", middleSectionOfName);

        bool startsWith = name1.StartsWith("\"Pr");
        bool startsWith2 = name2.StartsWith("\"Pr");

        Console.WriteLine("Does name 1 starts with \"Pr? {0}", startsWith);
        Console.WriteLine("Does name 2 starts with \"Pr {0}", startsWith2);


        string word = "Let's creat bigger wolrd";
        Console.WriteLine(word);

        int wordlength = word.Length;
        Console.WriteLine("{0}", word.Length);
        Console.WriteLine(wordlength);

        word = word.Replace("bigger", "better");
        Console.WriteLine(word);

        word = word.ToLower();
        Console.WriteLine(word);

        word = word.ToUpperInvariant();
        Console.WriteLine(word);

        bool better = word.Contains("BETTER");
        Console.WriteLine(better);

        string substring = word.Substring(1, 2);
        Console.WriteLine(substring);

        Console.WriteLine(word.Substring(1, 2));
        Console.WriteLine(word.EndsWith("BETTER WORLD"));
        Console.WriteLine(word.CompareTo(word));


        //Numeric Conversions
        int number1 = 7;
        double number2 = 5.5;

        double convNumber1 = number1;
        int convNumber2 = (int)number2;

        Console.WriteLine("{0} rounded to integer equals {1}", number2, convNumber2);
        Console.WriteLine(convNumber1);


        //Declaring Constants
        const int myIntConstant = 7;

        Console.WriteLine("\nPi in math equals " + Math.PI);

        DayOfWeekend today = DayOfWeekend.Monday;
        int NumberOfDay = (int)today;
        Console.WriteLine(NumberOfDay);

        //Console input

        //Console.WriteLine("\nHi, what is your name?");
        //string yourName = Console.ReadLine();
        //Console.WriteLine("Hi {0}, have a nice day!?", yourName);

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hi {0}, tell me the numeber", name);

        int value2 = int.Parse(Console.ReadLine());
        value2 += 10;
        Console.WriteLine("That number + 10 equals {0}", value2);

       //Time for test and excercise - next.cs



       
        


        


    }
}
