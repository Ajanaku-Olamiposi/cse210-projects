public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
         _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        int wordsCount = _words.Count;
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(wordsCount);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string Text = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {Text}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.isHidden());
    }
}