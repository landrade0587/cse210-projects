using System;

class Program
{
    static void Main(string[] args)
    {
        Random _random = new Random();

        DicScriptures _dicScriptures = new DicScriptures();
        // From scripture to select random of the list of dictionary
        List<Dictionary<string, string>> Scriptures = _dicScriptures.getScriptures();

        // We used the populate conditional of reference and scripture classes 
        Console.Clear();
        int _randomNumber = _random.Next(0, Scriptures.Count);
        if (Scriptures[_randomNumber].Count-1 > 3){
            Reference _reference = new Reference(Scriptures[_randomNumber]["Book"], int.Parse(Scriptures[_randomNumber]["Chapter"]), int.Parse(Scriptures[_randomNumber]["FirstVerse"]), int.Parse(Scriptures[_randomNumber]["LastVerse"]));
            string Scripture = Scriptures[_randomNumber]["Scripture"];
            Scripture _scripture = new Scripture(_reference.GetReference(), $" {Scripture} ");
            _scripture.HideWord();
        
        }
          else{
            Reference _reference = new Reference(Scriptures[_randomNumber]["Book"], int.Parse(Scriptures[_randomNumber]["Chapter"]), int.Parse(Scriptures[_randomNumber]["FirstVerse"]));
            string Scripture = Scriptures[_randomNumber]["Scripture"];
            Scripture _scripture = new Scripture(_reference.GetReference(), $" {Scripture} ");
            _scripture.HideWord();
           }
        
    }
}