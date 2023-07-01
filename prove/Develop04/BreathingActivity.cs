using System; 

public class BreathingActivity: Activity{
    public BreathingActivity(): base("Breathing.", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. "){       
    }
    public override void Run()
    {
      Console.WriteLine("Get ready... ");
      DispAnimation();
      Console.WriteLine();
      Console.WriteLine();
      DateTime startTime = DateTime.Now;

      while((DateTime.Now - startTime).TotalSeconds <GetTime()){

        Console.Write("Breathe in... ");
        for(int i = 5; i >= 1; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");            
        }

        Console.WriteLine();

        Console.Write("Breathe out... ");
        for(int i = 5; i >= 1; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
        Console.WriteLine();
      } 
    }
}