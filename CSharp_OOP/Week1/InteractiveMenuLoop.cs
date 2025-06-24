using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        int counter = 0;

        do
        {
            Console.WriteLine(counter);
            counter += 1;

            Console.WriteLine("Do you want to continue?");
            int menu = int.Parse(Console.ReadLine()); 
            option = menu;

        } while (option != 1);

    }
}
