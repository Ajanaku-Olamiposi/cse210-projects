public abstract class Exercise
{
    protected DateTime _date;
    protected int _length;

    public Exercise(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }
    public abstract int Distance();
    public abstract int Speed();
    public abstract int Pace();
    public abstract string GetSummary();
}