public abstract class Exercise{
    protected string _type;
    protected DateTime _date;
    protected int _length;
    protected double _distance;
    protected string _unit;
    

    public virtual double getDistance(){
        return _distance;
    }
    public virtual double getSpeed(){
        return _distance/_length*60;
    }
    public virtual double getPace(){
        return _length/_distance;
    }

    public virtual string getSummary(){
        return $"{_date} {_type} ({_length} min.) -Distance: {_distance} {_unit}, Speed: {getSpeed()} {_unit} per hour, Pace: {getPace()} min per {_unit}";
    }
    public void toKilometer(){
        _unit = "kilometer";
        _distance = _distance * 1.6;

    }
    public void toMile(){
        _unit = "mile";
        _distance = _distance/1.6;
    }
}
