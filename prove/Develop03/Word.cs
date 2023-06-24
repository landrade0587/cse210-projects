using System;

// We defined word class we will use to hide the word of each word object type
public class Word{
    // we defining and declaring variables  that will use all of them are private
    // so people outside ofthe programn won not be able to access them inside of them won not be anything yet
    private string _word;
    private string _hiddenWord;
    private string _text;

    // Populating ours variables  with setters and getter
    public void SetWord(string word){
        _word = word;
        // This method will help me to know how many times the character _ will be repeated
        // We will repeat _ with _word.Length times
        _hiddenWord = String.Concat(Enumerable.Repeat("_",_word.Length));
    }

    public void SetText(string text){
        _text = text;
    }

    public string GetTextReplaced(){
        // This method will return the text with the word replaced
        // we used replace method to switch the word with the hiddenword 
        // Also we added space at the begining and at the end of the item
        // that will be replaced and the one  that will rplaced it
        // on ours main class program we added spaces at the begining and at the end
        // of the text when it is pass as an argument, doing this first and last word
        // will be also replaced when they are sleceted randommly 

        _text = _text.Replace($" {_word} ", $" {_hiddenWord} ");
        return _text;
    }
}