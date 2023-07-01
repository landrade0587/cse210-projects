using System;
class Program
{
    static void Main(string[] args)
    {
        // we added in this part the menu displayed and calls the all to theactivities
        // when the user choose and we put everything inside 
        // and to be able to control the repetition program  
        int _option;
        do{
            Console.WriteLine("1. Star Breathing activity. ");
            Console.WriteLine("2. Start Reflecting activity. ");
            Console.WriteLine("3. Start Listening activity. ");
            Console.WriteLine("4. Quit. ");
            Console.WriteLine(" Please Select an option: ");

            // In this part of the code we  wiill check if  the user enter a letter instead of a number
            // Conditional, if that the case we will displayed a message and the program start again
            if (!int.TryParse(Console.ReadLine(), out _option)){
                Console.Clear();
                Console.WriteLine("Please Introduce a valid option!! ");
                continue;
            }

            Activity _newActivity = null;

            switch(_option){
                case 1: 
                    _newActivity = new BreathingActivity();
                    break;
                
                case 2:
                   _newActivity = new ReflectionActivity();
                   break;

                case 3: 
                   _newActivity = new ListeningActivity();
                   break;
                
                case 4: 
                   Console.WriteLine("Thanks for participating... See You... in other time...");
                   Environment.Exit(0);
                   break;
            }

            if (_option <= 3 && _option > 0){

                Console.Clear();
                _newActivity.DisplayStartMessage();
                _newActivity.Run();
                _newActivity.DisplayEndMessage();

            }

            else if(_option >4){

                Console.Clear();
                Console.WriteLine("Please Introduce a valid option!! ");

            }

        } while(_option != 4);        
    }
}