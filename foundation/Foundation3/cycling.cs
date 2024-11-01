public class Cycling : Exercise
{
    private int _speed;
    public Cycling(int speed, DateTime date, int length) : base(date, length)
    {
        _speed = speed;
    }
    public override int Distance()
    {
        return _speed * _length;
    }
    public override int Speed()
    {
        return _speed;
    }
    public override int Pace()
    {
        return 60/_speed;
    }
    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Cycling({_length})- Distance: {Distance()}km, Speed: {Speed()}kph, Pace: {Pace()}min per km.";
    }
} 