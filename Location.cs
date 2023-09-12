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

    public DisplayLocationInfo(Player playerobj)
    {
        locationobj = LocationByID(playerobj.CurrentLocation);
        Console.WriteLine($"You are currently at location : {locationobj.Name}")
        Console.WriteLine($"{locationobj.Discription}")
    }
}