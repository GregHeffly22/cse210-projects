public class Swimming:Exercise{
    private int _laps;

    public override double getDistance(){
        if (_unit =="miles"){
            return _laps * 50 / 1000;
        }
        else return Math.Round(_laps * 50 / 1000 *.62, 2);
    }
    
    public override double getSpeed(){
        return Math.Round(getDistance()/_length * 60, 2);
    }
    public override double getPace(){
        return Math.Round(getSpeed()/60, 2);
    }

    public override string getSummary(){
        return $"{_date} {_type} ({_length} min.) -Distance: {getDistance()} {_unit}, Speed: {getSpeed()} {_unit} per hour, Pace: {getPace()} min per {_unit}";
    }

    public Swimming(DateTime date, int length, int laps, string unit){
        _type = "swimming";
        _length = length;
        _unit = unit;
        _laps = laps;
    }

}
