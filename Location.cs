public class Location
{
    public int ID;
    public string Name;
    public string Discription;

    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location LocationToNorth;
    public Location LocationToSouth;
    public Location LocationToEast;
    public Location LocationToWest;



    public Location(int id, string name, string discription, Quest questavailablehere, Monster monsterlivinghere)
    {
        ID = id;
        Name = name;
        Discription = discription;
        Quest QuestAvailableHere = questavailablehere;
        Monster MonsterLivingHere = monsterlivinghere;

    }
}