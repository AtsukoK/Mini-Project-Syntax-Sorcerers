using static World;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("This is game , no work yet.\n");


        //game starting point, 
        Console.WriteLine("Enter name for player:");
        string playername = Console.ReadLine();
        Player player1 = new Player(100, 1, 1, 100, playername); // curr hp, location id , wpn,max hp, name

        Console.WriteLine("You will now enter game world.\n");

        bool GameOver = true; // should be false on game start for testing, its true

        //tutorial - testing phase

        Tutorial();


        //Game loop

        while (!GameOver)  // Game status, on true will exit
        {
            Console.WriteLine("Game status: running");
        }
    }
    public static void Tutorial()
    {
        Console.WriteLine("Tutorial Time!\n");
        Console.WriteLine("You are playing an RPG, throughout the game you will encounter enemies.");
        Console.WriteLine("We will now simulate one combat scenario.");

        Player playertutorial = new Player(100, 666, 1, 100, "adventurer");
        Location currentlocationobject = DisplayLocationInfo(playertutorial);
        CheckForMonster(currentlocationobject);

    }

    public static Location DisplayLocationInfo(Player playerobj)
    {
        Location locationobj = World.LocationByID(playerobj.CurrentLocation);
        Console.WriteLine($"\nYou are currently at location : {locationobj.Name}");
        Console.WriteLine($"{locationobj.Discription}");
        return locationobj;
    }

    public static Monster CheckForMonster(Location enemycheck)
    {
        if (enemycheck.MonsterLivingHere != null)
        {
            Console.WriteLine($"\n Enemy spotted");
            Monster enemy = enemycheck.MonsterLivingHere;
            return enemy;
        }
        else
        {
            return null;
        }

    }


}