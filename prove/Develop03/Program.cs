using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("2 Nephi", 31, 3);
        Scripture scripture = new Scripture(reference, "For my soul delighteth in plainness; for after this manner doth the Lord God work among the children of men. For the Lord God giveth light unto the understanding; for he speaketh unto men according to their language, unto their understanding.");

        Console.WriteLine(scripture.ToText());
        Console.WriteLine("Press enter to hide a few words, type start to restart again, or quit to exit.");

        String input = Console.ReadLine();

        while (input != "quit" && !scripture.IsFullyHidden())
        {
            Console.Clear();
            scripture.HideWords(3);
            Console.WriteLine(scripture.ToText());
            Console.WriteLine();
            Console.WriteLine("Press enter to hide a few words, type start to restart again, or quit to exit.");
            input = Console.ReadLine();
        }
    }
}