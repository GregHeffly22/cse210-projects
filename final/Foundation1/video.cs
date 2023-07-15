public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }
    public void addComment(Comment comment){
        _comments.Add(comment);
    }
    public int countComments(){
        return _comments.Count();
    }
    public void displayComments(){
        foreach (Comment comment in _comments){
            Console.WriteLine(comment.getName());
            Console.WriteLine(comment.getText());
        }
    }
    public string getFormatedInfo(){
        return $"{_title} by {_author} Runtime: {_length} seconds";
    }
}
