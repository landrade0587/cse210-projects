using System;

// In this part entry the class, which is responsible for each of the inputs that the user enters.
public class Entry
{    // We declare variables that will be used in my class
    // We will variable _prompt for to catch the ramdom prompt generated for ours promp generator
    public string _prompt;

    // The variable to display in the user
    public string _displayEntry;

    // So we need the current date, so we call datetime.now
    // so we parse it into a string and figure out what format we want the date in.
    public string_date = DateTime.Now.ToString("M/d/yyyy");

    // This variable _entry will hold the user entry
    public string _entry;

    // We need to connect with prompgenerator class  with entry class, bacause we need the prompt
    // for two methods (Store/EntryDisp) the to be able to do it. We create PrompGenerator object
    public PrompGenerator _randomPrompt = new PrompGenerator();  

    // We use this variable for store user entry with date and prompt together with a special
    // format in order to recover them later when user uses load method
    public string _storeEntry;
    
    // Store method to store user entry with date and prompt
    public void Store(){
        _entry = _entry.Replace("," , "~");
        _storeEntry = $"{_date},{_prompt},{_entry}";
    }

    // User entry with EntryDisp method
    public void EntryDisp(){
        _displayEntry = _entry.Replace("~" , ",");
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_displayEntry}");
        Console.WriteLine();
    }
}