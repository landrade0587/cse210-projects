using System;

class Reference{

    // We Defining and declaring all variables that will be use in this class.
    private string _book;
    private int _chapter;
    private int _verseBegin = 0;
    private int _verseEnd = 0;
    private string _reference; 

    // We Making all the contructores for three different cases
    public Reference(string book, int chapter, int verseBegin){
        _book = book;
        _chapter = chapter;
        _verseBegin = verseBegin;
        _reference = $"{_book} {_chapter}:{_verseBegin}";        
    }

    public Reference(string book, int chapter, int verseBegin, int verseEnd){
        _book = book;
        _chapter = chapter;
        _verseBegin = verseBegin;
        _verseEnd = verseEnd;
        _reference = $"{_book} {_chapter}:{_verseBegin}-{_verseEnd}";        
    }

    // We sending the reference back as string
    public string GetReference(){
        return _reference;
    }
}   