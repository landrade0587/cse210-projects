using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assigment1 = new Assignment("Luis Andrade", "Division");


        Console.WriteLine($"{assigment1.GetSummary()}");
        Console.WriteLine();

        MathAssigment assigment2 = new MathAssigment("Luis Andrade", "Division", "7.3","8-19");
        Console.WriteLine($"{assigment2.GetSummary()}");
        Console.WriteLine($"{assigment2.GetHomeWorkList()}");
        Console.WriteLine();

        WrittingAssigment assigment3 = new WrittingAssigment("Vanessa Mancilla", "Colombian History", "Calendar Wordl");
        Console.WriteLine($"{assigment3.GetSummary()}");
        Console.WriteLine($"{assigment3.GetWrittingInformation()}");
    }
}