class Program
{
    public void Main()
    {
        Console.WriteLine("This is game , no work yet.")
    }

    //game starting point, 
    Console.WriteLine("Enter name for player:    ...");
    playername = Console.ReadLine();
    Player player1 = new Player(100, 1, 1, 100, playername);

    Console.WriteLine("You will now enter game world.")
}