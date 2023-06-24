using System;

//Scripture will be the class that will have more importance
public class Scripture{

    // We defining and declaring, With the list of words object for each
    // word of the string in order hide andreplace them likewise a need string list object
    // to first get them all split as an array  menber and then we will populated my list of word objects 
    // also we will need a ramdom object to select a ramdom menber of the word list
    private List<Word> _words = new List<Word>();
    private string _scripture;
    private string[] _allWords;
    private Random _random = new Random();
    private string _reference;

    // We Constructor for the scripture classs, it will accept
    // a reference and the scripture itself
    public Scripture(string reference, string scripture){
        _scripture = scripture;
        _reference = reference;
        _allWords = _scripture.Split(" ");
        int counter = 0;        
     

       // This part we will populate list word object making use of a fore-ach loop
       // and the  string list with the words inside of them we did also  populate the word 
       // variable inside of each word object
       foreach (string word in _allWords){
        _words.Add(new Word());
        _words[counter].SetWord(word);
        counter +=1;
       }
    }

    // HideWord method will be the one that wiill almost all ofthe logic of my program
    public void HideWord(){
        // We need a variable to control the user decision, we will define it as null at the begining
        string _userDecision = null;
           // We used the loop do will use make user press enter until there is not any word object
           // Inside of the list of objectalso it will allow to print the whole
           // scripture withoth any word hidden yet
           do{
              DisplayScripture();
              Console.WriteLine($"Please Press enter to continue or type quit to finish:");
              _userDecision = Console.ReadLine();
              Console.Clear();
                // used the conditional if the user type quit finishing the program
                 if (_userDecision != "quit"){
                    // This loop to hide three word each time the user press enter although if a word
                    // is twice or more in the string and that word is selected it will hide more than four;
                    // likewise at the end could be left two or one word depending if all word is sum is a number
                    // dividible of 3 or if in a moment there were hidden more than 3 words for what we mwncioned before.
                    for(int i = 0; i <=2; i++){
                        //the control the program make this conditional run when there is
                        // still left a word object inside of the list words
                        if(_words.Count >= 1){
                            int _randomNumber = _random.Next(0 , _words.Count-1);
                            _words[_randomNumber].SetText(_scripture);
                            _scripture = _words[_randomNumber].GetTextReplaced();
                            _words.RemoveAt(_randomNumber);
                        } 
                          else{
                            break;
                          }
                    }  
                 } else{
                    break;
                   }
           } 
             while(_words.Count-1 >= 0);
              DisplayScripture();
            }

             //DisplayScripture method it is a private method because it will be used only inside of the class
             private void DisplayScripture(){
                Console.WriteLine($"{_reference}{_scripture}");
             }
}