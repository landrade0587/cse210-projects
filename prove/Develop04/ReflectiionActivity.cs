using System;

public class ReflectionActivity: Activity{    
    private List<string> _prompts = new List<string>{"---Think of a time when you stood up for someone else---", "---Think of a time when you did something really difficult---",
                                 "---Think of a time when you did somethig selfless---", "---Think of a time when you helped someone in need---"};
    private List<string>_questions = new List<string>{"> Why was this experience meaningful to you?", "> Have you ever done anything like this before?", "> How did you get started?",
                                  "> How did you feel when it was complete?", "> What made this time different than other times when you were not as successful?",
                                  "> What is your favorite thing about this experience?", "> What could you learn from this experience that applies other situations",
                                  "> What did you learn about yourself through this experience?", "> How can you keep this experience in mind in the future"};
    
    public ReflectionActivity(): base("Reflection", @"This activity will help you reflect on times in your life when you have shown strength and resilience. 
    This will help you recognize the power you have and how you can use it in other aspects of your life."){
    }
    public override void Run()
    {
        Console.WriteLine("Get ready...");
        DispAnimation();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        int _randomNumber = _rand.Next(0, _prompts.Count - 1);

        Console.WriteLine($"{_prompts[_randomNumber]}");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, please press enter to continue. ");
        Console.ReadLine();

        Console.WriteLine($"Now ponder on each of the following questions as they related to this experience. ");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        for(int i = 5; i >= 1; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();

        DateTime startTime = DateTime.Now;
        while((DateTime.Now - startTime).TotalSeconds < GetTime()){
            _randomNumber = _rand.Next(0, _questions.Count - 1);
            Console.Write($"{_questions[_randomNumber]} ");
            DispAnimation(15);
            _questions.RemoveAt(_randomNumber);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}