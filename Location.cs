class Location
{
    public int ID;
    public string Name;
    public string Discription;

    public Location(int id, string name, string discription, Quest questavailablehere, Monster monsterlivinghere)
    {
        ID = id;
        Name = name;
        Discription = discription;
        QuestAvailableHere = questavailablehere;
        MonsterLivingHere = monsterlivinghere
    }

    public void PlayerSeeLocation(World world)
    {
        foreach (Location location in world.Locations)
        {
            Console.WriteLine($"You are currently at: {location.Name}");
            Console.WriteLine($"Description: {location.Discription}");
        }
    }
}