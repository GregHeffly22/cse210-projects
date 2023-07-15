public class Running:Exercise{

    public Running(DateTime date, int length, int distance){
        _date = date;
        _length = length;
        _distance = distance;
    }
    
    public Running(DateTime date, int length, int distance, string unit){
        _type = "running";
        _length = length;
        _unit = unit;
        _distance = distance;
    }

}