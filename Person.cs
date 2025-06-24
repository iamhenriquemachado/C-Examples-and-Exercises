using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person
        {
            Name = "Henrique Machado",
            Age = "26"
        };

        Console.WriteLine(p.ToString());

    }
}
