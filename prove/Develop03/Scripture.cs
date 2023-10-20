using System;
using System.Collections.Generic;

public class Scripture{

    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string bibleText){
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = bibleText.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        foreach(string wordText in wordArray){

            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    //getters and setters
    public Reference Reference{
        get {return _reference;}
        set {_reference = value; }
    }

    public List<Word> Words{
        get { return _words;}
    }

    

    public void HideWords(int count){
        Random random = new Random();
        List<Word> visibleWords = Words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count <= count)
        {
            foreach (Word word in visibleWords)
            {
                word.Hide();
            }
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }



    public void GetRenderedtext(){
        Console.Write(_reference.GetDisplayText());
        Console.Write("\"");
        foreach (Word word in _words)
        {
            Console.Write(word.GetRenderedText());
            Console.Write(" ");
        }
        Console.Write("\"");
    }



    public bool IsCompletelyHidden(){
        
        return Words.All(word => word.IsHidden);
    }


}