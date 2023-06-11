using System;

class Program
{
    static void Main(string[] args)
    {
        //We declared the variable  that will control
        // the do while loop
        String contPlaying = "";
        do{
            //We have to create the variables that we will use inside of the do while
            // and while loopss also this will restarts the variable if the user wants to play again
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,11);
            int inpNumber = 0;
            String inputTwo;
            int tries = 0;

            //the loop tha will be the one control  the game itself
            while (magicNumber != inpNumber)
            {
                tries++;
                Console.Write("What is your guess? ");
                inputTwo = Console.ReadLine();
                inpNumber = int.Parse(inputTwo);

                if (inpNumber > magicNumber)
                {
                    Console.WriteLine("Lower");  
                }

                else if(inpNumber < magicNumber)
                {
                    Console.WriteLine("Higther");
                }

                else 
                {
                    Console.WriteLine("You guessed it! ");
                    Console.WriteLine($"It tooked you {tries} tries! ");
                    Console.Write("Do you want to comtinue ? ");
                    contPlaying =Console.ReadLine();
                }


            }
        } while(contPlaying == "yes");
    }
}