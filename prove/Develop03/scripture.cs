using System;

public class Scripture{
    private List<Word> _scripture;
    private string _text;

    public Scripture(string text){
        _text = text;
        string[]words = text.Split();
        
        List<Word> list = new List<Word>();

        foreach (string line in words){
            Word part = new Word();
            part.setWord(line);
            list.Add(part);
        }
        _scripture = list;
    }
    public void displayScripture(){
        foreach (Word line in _scripture){
            Console.Write($"{line.getWord()} ");
        }
        
    }

     public List<Word> showScripture(){
        return _scripture;
    }
    public void setScripture(List<Word> scripture){
        _scripture=scripture;
    }
      public List<Word> getScripture(){
        return _scripture;
    }
    public string setText(List<Word> scripture){
        string message = "";
        foreach (Word word in scripture){
            message += word.getWord();
        }
        return message;

    }
}   