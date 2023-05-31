public class WritingAssignment : Assignment{
    private string _title;

    public WritingAssignment(string title, string student, string topic){
        setAssignment(student,topic);
        _title = title;
    }

    public string getWritingInformation(){
        return $"{_title} by {_studentName}";
    }
}