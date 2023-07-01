using System;

public class ListeningActivity: Activity
{

    private List<string> _prompts = new List<string>{"--- Who are People that you appreciate?---", "---What are personal stregths of yours? ---",
                                                    "--- Who are people that you have helped this week? ---", "---When have you felt the holy Ghost this month? ---",
                                                    "--- Who are some of you personal heroes? ---"};

    public ListeningActivity(): base("Listening", @"This activity will help you reflect on the good thing in your life by having you list as many thing as you can in a certain area"){
        
    }   

    public override void Run()
    {
     Console.WriteLine("Get ready... ");
     DispAnimation();
     Console.WriteLine();
     Console.WriteLine("List as many responses you can to the following promt: ");
     int _randomNumber = _rand.Next(0, _prompts.Count - 1 );
     Console.WriteLine($"{_prompts[_randomNumber]}");
     Console.WriteLine($"You may beging in: ");

     for(int i = 5; i  >= 1; i--){
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }

     DateTime _startTime = DateTime.Now;

     while((DateTime.Now - _startTime).TotalSeconds <GetTime()){
        Console.Write("> ");
        Console.ReadLine();
     }

     Console.WriteLine();
    }
} 