using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideRandomWords(int count = 3)
    {
        for (int i = 0; i < count; i++)
        {
            var unhiddenWords = _words.Where(w => !w.IsHidden).ToList();
            if (unhiddenWords.Count == 0) return;

            var wordToHide = unhiddenWords[_random.Next(unhiddenWords.Count)];
            wordToHide.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", _words));
    }
}
