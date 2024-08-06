

Console.WriteLine("Basic Console I/O");
GetUserData();


static void GetUserData()
{
    Console.Write("Enter your name: ");
    string userName = Console.ReadLine();

    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("Hello {0}!", userName);

    Console.ForegroundColor = prevColor;
}