class Program
{
    public void Main()
    {
        Console.WriteLine("This is game , no work yet.");


        //game starting point, 
        Console.WriteLine("Enter name for player:");
        string playername = Console.ReadLine();
        Player player1 = new Player(100, 1, 1, 100, playername); // curr hp, location id , wpn,max hp, name

        Console.WriteLine("You will now enter game world.");

        bool GameOver = true; // should be false on game start for testing, its true

        //tutorial - testing phase

        Tutorial();


        //Game loop

        while (!GameOver)  // Game status, on true will exit
        {
            Console.WriteLine("Game status: running");
        }
    }
    public void Tutorial()
    {
        Console.WriteLine("Tutorial Time!");
        Console.WriteLine("You are playing an RPG, throughout the game you will encounter enemies.");
        Console.WriteLine("We will now simulate one combat scenario.");

        Player playertutorial = new Player(100, 666, 1, 100, "adventurer");
        Console.WriteLine(DisplayLocationInfo(playertutorial));
    }

}