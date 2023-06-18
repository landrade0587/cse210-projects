using System;

public class Journal{

    // We create to list of entry for teh save each in the ours entries and entry object
    // by doing this we will be able to access any feature in the entry class
    public List<Entry> _entries = new List<Entry>();

    // We will use the list length in order to iterate inside of it
    public int _listLenght; 

    // We added addEntries method will whit the entries  to the entry list and its values in the 
    //diferents methods and variables when the use decide to add  an entry 
    public void AddEntries(){
        _entries.Add(new Entry());
        _listLenght = _entries.Count;
        _entries[_listLenght - 1]._prompt =_entries[_listLenght - 1]._randomPrompt.PromptDis();
        _entries[_listLenght - 1]._entry = Console.ReadLine();
        Console.WriteLine();
        _entries[_listLenght - 1].Store();
    }

    // In this part we added EntriesDisp methods will display all the entries making use of
    // the EntryDisp method in the entry class, each entry will have its own EntryDisp methods
    public void EntriesDisp(){
        for (int i = 0; i  < _entries.Count; i++)
        {
            _entries[i].EntryDisp();
        }
    }

    // We load a file, a file that has already been saved; from that file we will get a string that
    // we will manipulate to store the old entries in the list of entries with their different behaviors
    // and attributes, therefore even when a new file is uploaded a new journal object will be created
    // there old entries will be saved and new ones added will be stored in the list of entries
    // after the previous ones, we will get the user's file name send to the function as parameter.
     public void Load(string fileName){
        string[] lines =  System.IO.File.ReadAllLines(fileName);
        _entries.Clear();
        foreach (string line in lines){
            _entries.Add(new Entry());
            string[] parts = line.Split(",");
            _listLenght = _entries.Count;
            _entries[_listLenght - 1]._date = parts[0];
            _entries[_listLenght - 1]._prompt = parts[1];
            _entries[_listLenght - 1]._entry = parts[2].Replace("~" , ",");
            _entries[_listLenght - 1].Store();
        }
    }

    //The save method will store the entries in the file, so we will have the user's file name.
    // Where the method will use it as a parameter we will save it as a special string that will
    // be in _storeEntry for which the previous entry gave rise to the value of said variable

    public void Save(string fileName){
            using (StreamWriter  outputFile = new StreamWriter(fileName)){
                foreach(Entry _entry in _entries){
                    outputFile.WriteLine($"{_entry._storeEntry}");    
                }
            }      
         }
}