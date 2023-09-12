public class Location
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } // Fixed the spelling error

    public Quest QuestAvailableHere { get; set; }
    public Monster MonsterLivingHere { get; set; }
    public Location LocationToNorth { get; set; }
    public Location LocationToSouth { get; set; }
    public Location LocationToEast { get; set; }
    public Location LocationToWest { get; set; }

    public Location(int id, string name, string description, Quest questAvailableHere, Monster monsterLivingHere)
    {
        ID = id;
        Name = name;
        Description = description; // Fixed the spelling error
        QuestAvailableHere = questAvailableHere; // Fixed the constructor assignments
        MonsterLivingHere = monsterLivingHere; // Fixed the constructor assignments
    }

    public void DisplayLocationInfo(Player playerobj)
    {
        Location locationobj = World.LocationByID(playerobj.CurrentLocation);
        Console.WriteLine($"You are currently at location : {locationobj.Name}");
        Console.WriteLine($"{locationobj.Description}");
    }
}
