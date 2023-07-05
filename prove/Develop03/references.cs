using System;

public class Reference {
    private string nameOfBook;
    private int scriptChapter;
    private int startOfVerse;
    private int? endOfVerse;

    public Reference(string name, int chapter, int verse) {
        nameOfBook = name;
        scriptChapter = chapter;
        startOfVerse = verse;
    }

    public Reference(string name, int chapter, int verseStart, int verseEnd) {
        nameOfBook = name;
        scriptChapter = chapter;
        startOfVerse = verseStart;
        endOfVerse = verseEnd;
    }

    public string ToText() {
        if (endOfVerse == null) {
            return $"{nameOfBook} {scriptChapter}:{startOfVerse}";
        } else {
            return $"{nameOfBook} {scriptChapter}:{startOfVerse}-{endOfVerse}";
        }
    }
}