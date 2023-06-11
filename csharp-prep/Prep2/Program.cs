using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Introduce your percentage grade: ");
        string userInput = Console.ReadLine();
        int gradePer = int.Parse(userInput);
        string letter;

        if (gradePer >= 90)
        {
            letter = "A";
        }

        else if (gradePer >= 80)
        {
            letter = "B";
        }

        else if (gradePer >= 70)
        {
            letter = "C";
        }

        else if (gradePer >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        if (gradePer % 10 >= 7 && !(letter == "A" || letter == "F"))
        {
            letter +="+";
        }

        else if (gradePer % 10 < 3 && letter != "F")
        {
            letter += "-";
        }


        //printing the grade in letter
        Console.WriteLine($"Your grade is {letter}");

        // Now We Will aadd conditionals to determine
        // if the user passed or not

        if (gradePer >= 70)
        {
            Console.WriteLine("Congratulations you passed the course. !!");
            
        } 

        else
        {
            Console.WriteLine("Sorry  you have not approved, although if you try harder you will do it next) time !!");
        }
    }
}