using AI_game;
using System;

class Programm
{
    public static void Main() {
        Person test = new Person();
        //test.CurrentTolerances = new Tolerance(1.0);
        test.ProgressStatement();
        Console.WriteLine(test.Needs);
        Console.WriteLine(test.Happiness);
        for (int i = 0; i < 10; i++)
        test.ProgressStatement();
        Console.WriteLine(test.Needs);
        Console.WriteLine(test.PersonsType.Name);
        Console.WriteLine(test.Happiness);
        Console.WriteLine();
        for (int i = 0; i < 2; i++)
        {
            Person person = new Person();
            Console.WriteLine(person.CurrentTolerances);
            Console.WriteLine(person.PersonsType.Name);
            person.ProgressStatement();
            Console.WriteLine(person.Needs);
            person.ProgressStatement();
            Console.WriteLine(person.Needs);
            Console.WriteLine();
        }
        
    }
}