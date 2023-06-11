using System;

class Program
{
    static void Main(string[] args)
    {  
       //User imput added
       Console.Write("What is your first name:? ");
       string first_name = Console.ReadLine();

       Console.Write("What is your last name:? ");
       string last_name = Console.ReadLine();   

       //Added the output
       Console.WriteLine($"Your name is: {last_name}, {first_name} {last_name}.");        
    }
}