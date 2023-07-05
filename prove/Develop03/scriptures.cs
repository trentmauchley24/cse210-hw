using System;
using System.Collections.Generic;

public class Scripture {
    private Reference scriptReference;
    private List<Word> scriptWords;
    public Scripture(Reference reference, string text) {
        scriptReference = reference;
        scriptWords = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words) {
            scriptWords.Add(new Word(word));
        }
    }
    public void HideWords(int n) {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in scriptWords) {
            if (word.IsVisible()) {
                visibleWords.Add(word);
            }
        }
        if (visibleWords.Count < n) {
            n = visibleWords.Count;
        }
        for (int i = 0; i < n; i++) {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }
    public bool IsFullyHidden() {
        foreach (Word word in scriptWords) {
            if (word.IsVisible()) {
                return false;
            }
        }
        return true;
    }
    public string ToText() {
        string output = $"{scriptReference.ToText()}\n";
        foreach (Word word in scriptWords) {
            output += $"{word.ToText()} ";
        }
        return output;
    }
}