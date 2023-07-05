using System;

public class Word {
    private string wordContent;
    private bool visibleWords;
    public Word(string content) {
        visibleWords = true;
        wordContent = content;

    }
    public void Hide() {
        visibleWords = false;
    }
    public void Show() {
        visibleWords = true;
    }
    public bool IsVisible() {
        return visibleWords;
    }
    public string ToText() {
        if (visibleWords) {
            return wordContent;
        } else {
            return new String('_', wordContent.Length);
        }
    }
}