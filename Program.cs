using AI_game;
using System;

class Programm
{
    public static void Main() {
        Person person = new Person();
        Console.WriteLine(person.CurrentTolerances.Physiological);
        Console.WriteLine(person.CurrentTolerances.Security);
        Console.WriteLine(person.CurrentTolerances.Social);
        Console.WriteLine(person.CurrentTolerances.Prestigious);
        Console.WriteLine(person.CurrentTolerances.Spiritual);
        Console.WriteLine(Math.Pow(person.CurrentTolerances.Physiological, 2) + Math.Pow(person.CurrentTolerances.Security, 2) + Math.Pow(person.CurrentTolerances.Social, 2) + Math.Pow(person.CurrentTolerances.Prestigious, 2) + Math.Pow(person.CurrentTolerances.Spiritual, 2));
        person.ProgressStatement();
        Console.WriteLine(person.PersonsType.Name);
        Console.WriteLine(person.Needs);
        for(int i = 0; i < 100; i++)
            person.ProgressStatement();
        Console.WriteLine();
        Console.WriteLine(person.Needs);
    }
}