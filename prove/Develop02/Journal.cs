using System;
using System.Collections.Generic;
using System.IO;
public class Journal{
    public List<Entry> _entries;

    public void  AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }
    public void DisplayAll(){
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using(StreamWriter writeEntryToFile = new StreamWriter(file))
    {
        foreach(Entry entry in _entries){
            writeEntryToFile.WriteLine(entry.ToString());
            writeEntryToFile.WriteLine("-----------------------------");
        }
    }

    }
    public void LoadFromFile(string file){
        _entries.Clear();
        if(!File.Exists(file)){
            Console.WriteLine("File not found");
            return;
        }
        string [] lineInFile = File.ReadAllLines(file);
        List<string> dataToBeLoaded = new List<string>();
        foreach(string eachLineInFIle in lineInFile){
            if(eachLineInFIle == "-----------------------------"){
                if(dataToBeLoaded.Count >= 3){
                    string date = dataToBeLoaded[0];
                    string prompt = dataToBeLoaded[1];
                    string activity = dataToBeLoaded[2];
                    _entries.Add(new Entry(date, prompt, activity));
                }
                dataToBeLoaded.Clear();
            }
            else{
                dataToBeLoaded.Add(eachLineInFIle);
            }

            }
        }

}