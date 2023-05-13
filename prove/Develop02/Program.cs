using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
       TerminalServices srv = new TerminalServices();
       Files files = new Files();
       
       Entry ety = new Entry();


       int reception = 1;

       while (reception != 5){
            
            srv.DisplayMenu();
            reception = srv.ReadInput();
            
            
            if (reception == 1){
                
                ety._question = srv.DisplayRandomQuestion();
                ety.SetEntry();
            }
            else if  (reception == 2){
                Console.WriteLine(ety._today);
                Console.WriteLine(ety._question);
                Console.WriteLine(ety._answer);
                
            }
            else if (reception == 3){
                Console.WriteLine("What File is it in?");
                files._filename = Console.ReadLine();
                string[] entry = files.ReadItem(files._filename);
                List<string> cleaned = new List<string>();
                foreach (string line in entry){
                    string[] part = line.Split(",");
                    
                    cleaned.Add(part[0]);
                    cleaned.Add(part[1]);
                    cleaned.Add(part[2]);
                }
                ety._today = cleaned[0];
                ety._question = cleaned[1];
                ety._answer = cleaned[2];
            }
            else if (reception == 4){
                Console.WriteLine("What will we name the file?");
                files._filename = Console.ReadLine();
                files.WriteFile(ety._today, ety._question, ety._answer);
            }
       }
       

    }
}
public class TerminalServices{
            List<string> _menu = new List<string>(){
                "Please Select one of the following outputs (Input the number):",
                "1. Write",
                "2. Display",
                "3. Load" ,
                "4. Save",
                "5. Quit",
                "What would you like to do?"
            };
            List<string> _questions = new List<string>(){
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What was the most meaningful thing someone said to me today?",
                "What made you smile today?",
                "Would you live in today over and over like it was Groundhog Day?"
            };
            public void DisplayMenu(){
                
                foreach (string line in _menu){
                    Console.WriteLine(line);
                }
            }
            public string DisplayRandomQuestion(){
                Random rnd = new Random();
                int location = rnd.Next(1,8);
                string prompt = _questions[location];
                Console.WriteLine(prompt);
                return prompt;
                
                
            }
            public int ReadInput(){
                string line = Console.ReadLine();
                return Convert.ToInt16(line);
            }
            public void PrintOutput(object input){
                Console.WriteLine(input);
            }
    }


public class Entry{
    public string _question = "";
    public string _answer = "";
    public string _today = DateTime.Now.ToString();
    public void SetEntry(){
        _answer = Console.ReadLine();
    }
}

public class Files{
    public string _filename ="";
    public void WriteFile(string date, string question, string answer){
        using (StreamWriter outputFile = new StreamWriter(_filename))

        outputFile.WriteLine($"{date},{question},{answer}");
    }
    public string[] ReadItem(string filename){
        string[] lines = System.IO.File.ReadAllLines(filename);
        return lines;
        
    
{
       

}
    }
    
}