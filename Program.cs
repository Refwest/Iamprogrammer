//See https://aka.ms/new-console-template for more information


namespace Iamprogrammer;

class Program
{
    //Pierwsze kroki w programowaniu językiem C#
    static void Main(string[] args)
    {
        int myIntegers = 5;
        myIntegers = 6;

        int myIntegers2;
        myIntegers2 = 6+6;
        int Sum = myIntegers - myIntegers2;
        double myDouble = 2.5;
        string myString = "I am programmer";
        bool myTrue = true;
        bool myTrue2 = false;
        char myCharacter = 'c';
        double myRemeinOperator = 10 % 4;

        Console.WriteLine("The sentence that {0} is {1,-5}.", myString, myTrue);
        Console.WriteLine("My mark for programming is " + myIntegers);
        Console.WriteLine(myIntegers2);
        Console.WriteLine(Sum / myDouble);
        Console.WriteLine(myRemeinOperator);

        //Add to variable
        double mySum = 3;
        mySum = mySum + 5;
        mySum += 2;
        Console.WriteLine("The value of mySum plus 7 equals {0}.", mySum);

        mySum++;
        Console.WriteLine("One more for mySum is {0}.", mySum);

        int A = 4;
        int B = A++;
        Console.WriteLine("The value of A is {0} and of the B is {1}.", A, B);

        int C = 4;
        int D = ++C;
        Console.WriteLine("The value of C is {0} and the of the D is {1}", C, D);


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







    }
}
