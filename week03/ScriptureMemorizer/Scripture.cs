using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;

        if (visibleWords.Count <= numberToHide)
        {
            foreach (Word word in visibleWords)
            {
                word.Hide();
            }
            return;
        }
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}