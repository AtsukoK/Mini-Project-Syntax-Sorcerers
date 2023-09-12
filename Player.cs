class Player
{
    public int CurrentHitPoints;
    public int CurrentLocation;
    public int CurrentWeapon;
    public int MaximumHitPoints;
    public string Name;


    public Player(int currenthitpoints, int currentlocation, int currentweapon, int maximumhitpoints, string name, int health)
    {
        CurrentHitPoints = currenthitpoints;
        CurrentLocation = currentlocation;
        CurrentWeapon = CurrentWeapon;
        MaximumHitPoints = maximumhitpoints;
        Name = name;
        Health = health;
    }

    public void PlayerHealthRecovery(Location location)
    {
        if (location.monsterlivinghere == null)
        {
            CurrentHitPoints += 20;
        }
    }
}