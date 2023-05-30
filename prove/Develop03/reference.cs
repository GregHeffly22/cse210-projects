using System;

public class Reference{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;



    public Reference(){
        _book = "";
        _chapter = "";
        _verseStart= "";
        _verseEnd= "";
    }
    public Reference(string book,string chapter ,string verse){
        _book= book;
        _chapter= chapter;
        _verseStart= verse;
        _verseEnd= "";
    }
    public Reference(string book,string chapter ,string verseStart, string verseEnd){
        _book= book;
        _chapter= chapter;
        _verseStart= verseStart;
        _verseEnd= verseEnd;
    }

        public void displayReference(){
            if (_verseEnd == ""){
                Console.WriteLine($"{_book} {_chapter}:{_verseStart}");
        }
            else{
                Console.WriteLine( $"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
    
}
   
}
