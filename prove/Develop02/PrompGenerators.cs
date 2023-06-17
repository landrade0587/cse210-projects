using System;
using System.Collections.Generic;

// PrompGenerator class will use to generate a random prompt from a list of prompt
public class PrompGenerator{

    // We declare the variables using the info of the this class
    public List<string> _prompt = new List<string>(){
        "What did I like the most about this day?";
        "Who should I talk to today?";
        "What was the most special thing that happened today?";
        "Why am I grateful today?";
        "What act of kindness did I do today?";
        "How did I notice the hand of the Lord acting in my life?";
        "how was my work today?";
        "Is there something that should be improved?";
    };
    
    //from the list we create a ramdom object variable.
    public Random _randomGenerator = new Random();

    // We see Will  cath the random prompt from _randomPrompt
    public string _randomPrompt

    // From the PromptDisp method it will store a random 
    // message and display it to the user and return it.
    public string PromptDis()
    {
        _randomPrompt = _prompts[_randomGenerator.Next(0, _prompts.Count)];
        Console.WriteLine($"{_randomPrompt}");
        return _randomPrompt;
    }
}