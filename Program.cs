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
        Console.WriteLine();
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
        Monster enemy = CheckForMonster(currentlocationobject);
        EngageInCombat(playertutorial, enemy);


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
            Monster enemy = enemycheck.MonsterLivingHere;
            Console.WriteLine($"\n Enemy spotted it's a {enemy.Name}\n");
            return enemy;
        }
        else
        {
            return null;
        }

    }

    public static void EngageInCombat(Player p_obj, Monster m_obj)
    {
        bool BattleStarted = true;

        while (BattleStarted)
        {
            while (p_obj.CurrentHitPoints > 0 && m_obj.CurrentHitPoints > 0 && BattleStarted)
            {
                Console.WriteLine($"{p_obj.Name}'s health is {p_obj.CurrentHitPoints}/{p_obj.MaximumHitPoints}");
                Console.WriteLine($"{m_obj.Name}'s health is {m_obj.CurrentHitPoints}/{m_obj.MaximumHitPoints}\n");
                // BattleStarted = false;
                Console.WriteLine("What is your course of action?   A) Attack   B) Do nothing\n");
                string combatinput = Console.ReadLine().ToUpper();
                if (combatinput == "A")
                {
                    p_obj.PlayerAttack(m_obj);
                }
                else
                {
                    Console.WriteLine("You do nothing lol\n");
                }
                m_obj.MonsterAttack(p_obj);


            }
            BattleStarted = false;
            Console.WriteLine("Battle concluded");
        }
    }

}