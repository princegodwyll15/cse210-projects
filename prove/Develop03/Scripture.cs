public class Scripture
{
    private Reference _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsToHide = Math.Min(numberToHide, _words.Count);
        Random random = new Random();
        HashSet<int> hiddenIndices = new HashSet<int>();

        for (int i = 0; i < wordsToHide; i++)
        {
            int index;
            do
            {
                index = random.Next(0, _words.Count);
            } while (hiddenIndices.Contains(index));

            hiddenIndices.Add(index);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.ToString() + " ";
        }
        return _reference.ToString() + " " + displayText.Trim();
    }
}
