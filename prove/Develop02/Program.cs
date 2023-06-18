using System;

class program
{
    static void Main(string[] args)
    {  // Mostly we declare the variables. We will use in ours main class. Second We will create too
       // one object of class journal this object which one we will use and it is for connected whit other class. 
       int userOption = 0;
       string input; 
       string fileName;
       Journal journal = new Journal();

       // We are use the loop while for the control in the menu and keep to returning the user  until in types 5
       while (userOption != 5){
          
          //We show the entire menu to the user
          Console.WriteLine("Welcome to the Journal Program.");
          Console.WriteLine("First Select one  of the following Choices:");
          Console.WriteLine("1. Write.");
          Console.WriteLine("2. Display.");
          Console.WriteLine("3. Save.");
          Console.WriteLine("4. Load.");
          Console.WriteLine("5. Quit.");
          Console.Write(" What would you like to do? ");

          // Rigth now user option in a variable and the parse it to an int parsing could
          // be ommited but we fell more comfortable working whith numbers
          input = Console.ReadLine();
          Console.WriteLine();

          userOption = int.Parse(input);

          // Now  if the conditionals to do the different thing that the menu
          // we offers to the user the next:
          if (userOption ==1){
              journal.AddEntries();
          }

          else if (userOption ==2){
               journal.EntriesDisp();
          }

          else if (userOption == 3){
             Console.Write("Plase First Introduce a file name: ");
             fileName = Console.ReadLine();
             Console.WriteLine();
             journal.Save(fileName);
          }

          else if (userOption == 4){
            Console.Write("Please Introduce a file name: ");
            fileName = Console.ReadLine();
            Console.WriteLine();
            journal.Load(fileName);
          }
       }     
    }
}