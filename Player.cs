public class Player
{
    public int CurrentHitPoints;
    public int CurrentLocation;
    public int CurrentWeapon;
    public int MaximumHitPoints;
    public string Name;

    public Player(int currenthitpoints, int currentlocation, int currentweapon, int maximumhitpoints, string name)
    {
        CurrentHitPoints = currenthitpoints;
        CurrentLocation = currentlocation;
        CurrentWeapon = currentweapon;
        MaximumHitPoints = maximumhitpoints;
        Name = name;
    }

    public void PlayerTakeDamage(int damage)
    {
        CurrentHitPoints -= damage;
        if (CurrentHitPoints < 0)
        {
            CurrentHitPoints = 0;
        }
    }

    public void PlayerAttack(Monster target)
    {
        int baseDamage = CalculatePlayerDamage();
        int totalDamage = baseDamage;

        if (CurrentWeapon != 0)
        {
            totalDamage += 10;
        }

        target.MonsterTakeDamage(totalDamage);
        Console.WriteLine($"{Name} attacks {target.Name}\n{totalDamage} damage\n");
    }

    public int CalculatePlayerDamage()
    {
        Random random = new Random();
        int damage = random.Next(0, 2);
        return damage;
    }

    public void PlayerHealthRecovery(Location location)
    {
        if (location.MonsterLivingHere == null)
        {
            CurrentHitPoints += 20;
        }
    }
}
