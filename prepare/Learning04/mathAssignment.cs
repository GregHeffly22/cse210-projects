public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbook, string problem, string student, string topic){
        setAssignment(student,topic);
        _textbookSection = textbook;
        _problems = problem;
    }
    public string getHomeworkList(){
        return $"Section {_textbookSection}, Problems {_problems} ";
    }

}

