public class Swimming : Exercise
{
    private int _numOfLaps;
    public Swimming(int numOfLaps, DateTime date, int length) : base(date, length)
    {
        _numOfLaps = numOfLaps;
    }
    public override int Distance()
    {
        return (_numOfLaps * 50)/1000;
    }
    public override int Speed()
    {
        return Distance()/_length;
    }
    public override int Pace()
    {
        return 60 / Speed();
    }
    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Swimming({_length})- Distance: {Distance()}km, Speed: {Speed()}kph, Pace: {Pace()}min per km.";
    }
} 