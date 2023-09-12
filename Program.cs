class Program
{
    public void Main()
    {
        Console.WriteLine("This is game , no work yet.")
    }

    //game starting point, 
    Console.WriteLine("Enter name for player:    ...");
    playername = Console.ReadLine();
    Player player1 = new Player(100, 1, 1, 100, playername); // curr hp, location id , wpn,max hp, name

    Console.WriteLine("You will now enter game world.");

    GameOver = false;

    //tutorial - testing phase


    //Game loop

    while(!GameOver)  // Game status, on true will exit
    {
        

    }


    public bool Tutorial()
    {
        Console.WriteLine("Tutorial Time!");
        Console.WriteLine("You are playing an RPG, throughout the game you will encounter enemies.");
        Console.WriteLine("We will now simulate one combat scenario.")

    }


}