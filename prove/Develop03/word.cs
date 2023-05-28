using System;

public class Word{
    private string _word;
    private bool _hidden;
    
    public Word(string line){
        _word = line;
        _hidden = false;
    }
    public Word(string word, bool status){
        _word = word;
        _hidden = status;
    }
    public Word(){
        _word ="";
        _hidden = false;
    }

    public void Hide(){
        _hidden = true;
        int wordLength = _word.Length;
        string cover = "";
        for (int i=wordLength; i>0; i-=1){
            cover += "_";
        }
        _word = cover;
        
    }
    
    public void Show(){
        _hidden = false;
    }
    public string getWord(){
        return _word;
    }
    public void setWord(string word){
        _word = word;
    }
    public bool getStatus(){
        return _hidden;
    }
}

