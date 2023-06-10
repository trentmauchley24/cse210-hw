using System;
class Program
{
    static void Main(string[] args)
    {
        person person = new person();
        person._givenName = "John";
        person._familyName = "Wick";
        person.ShowEasternName();
        person.ShowWesternName();
    }

}