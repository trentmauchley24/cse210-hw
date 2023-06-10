using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        
            Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
            {
            Console.WriteLine("What is the magic number? ");
            response = Console.ReadLine();
            int my_response = Int32.Parse(response);
            }
        
    }
}