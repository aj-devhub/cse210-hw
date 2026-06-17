// Swimming uses laps of 50 meters per lap

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double minutes, double laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double km = (_laps * 50) / 1000;
        return km;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}