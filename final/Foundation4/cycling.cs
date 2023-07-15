public class Cycling:Exercise{
    private int _speed;

    public override double getDistance(){
        return (_speed / 60) * _length;
    }
    public override double getPace()
    {
        return _speed/60;
    }
    public override string getSummary(){
        return $"{_date} {_type} ({_length} min.) -Distance: {getDistance()} {_unit}, Speed: {_speed} {_unit} per hour, Pace: {getPace()} min per {_unit}";
    }
    public Cycling(DateTime date, int length, int speed, string unit){
        _type = "cycling";
        _length = length;
        _unit = unit;
        _speed = speed;
    }
}