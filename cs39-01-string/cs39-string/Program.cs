// String Input Output
// Assignment #1
// Print the user's name and system time
// By Alan Luong
// ID #832899

class StringIO
{
    static void Main()
    {

        System.Console.WriteLine("Alan Luong");
        System.Console.WriteLine("{0}\n", System.DateTime.Now);

        System.Console.Write("What is your name? ");
        string username = System.Console.ReadLine();

        System.Console.WriteLine("Hi {0}, I'm Alan. Get lost.", username);
    }
}