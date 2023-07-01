using System;

public abstract class Activity{

    private string _description;
    private int _time;
    private string [] _animation = {"|","/","-","\\","|","/","-","\\"};
    private string _name;
    private DateTime _startTime;
    private DateTime _endTime;
    protected Random _rand = new Random();

       public  Activity(string name,  string description){
         _name = name;
         _description = description;         
       }
       public int GetTime(){
        return _time;
       }
       public void DisplayStartMessage(){
        Console.WriteLine($"Welcome to {_name} Activity. ");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your sesion? ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
       }
       public abstract void Run();

       public void DispAnimation(int time = 5){
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(time);
        int _counter = 0;

        while(DateTime.Now < _endTime){
            Console.Write(_animation[_counter]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            _counter++;

            if(_counter >= _animation.Count()){
                _counter = 0;
            }
        }
       }
       public void DisplayEndMessage(){
          Console.WriteLine("Well Done!!");
          DispAnimation();
          Console.WriteLine();
          Console.WriteLine($"You have completed another  {_time} seconds of {_name} Activity.");
          DispAnimation();
          Console.Clear();
       }
}