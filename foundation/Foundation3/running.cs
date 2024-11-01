public class Running : Exercise
{
    private int _distance;
    public Running(int distance, DateTime date, int length) : base(date, length)
    {
        _distance = distance;
    }
    public override int Distance()
    {
        return _distance;
    }
    public override int Speed()
    {
        return _distance/_length;
    }
    public override int Pace()
    {
        return 60 / Speed();
    }
    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Running({_length})- Distance: {Distance()}km, Speed: {Speed()}kph, Pace: {Pace()}min per km.";
    }
} 