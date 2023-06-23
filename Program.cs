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
        myIntegers2 = 7;
        int Sum = myIntegers - myIntegers2;

        double myDouble = 2.5;
        string myString = "I am programmer";
        bool myTrue = true;
        bool myTrue2 = false;
        char myCharacter = 'c';

        Console.WriteLine("The sentence that {0} is {1,-5}.", myString, myTrue);
        Console.WriteLine("My mark for programming is " + myIntegers);


    
    }
}
