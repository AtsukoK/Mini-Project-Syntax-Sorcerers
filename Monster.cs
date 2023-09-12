public class Monster
{
    public int CurrentHitPoints;
    public int ID;
    public int MaximumDamage;
    public int MaximumHitPoints;
    public string Name;

    public Monster(int id, string name, int maximumdamage, int maximumhitpoints, int currenthitpoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumdamage;
        MaximumHitPoints = maximumhitpoints;
        CurrentHitPoints = currenthitpoints;
    }

    public void MonsterTakeDamage(int damage)
    {
        CurrentHitPoints -= damage;
        if (CurrentHitPoints < 0)
        {
            CurrentHitPoints = 0;
        }
    }

    public void MonsterAttack(Player target)
    {
        int damage = CalculateMonsterDamage();
        target.PlayerTakeDamage(damage);
        Console.WriteLine($"{Name} attacks {target.Name}\n{damage} damage");
    }

    public int CalculateMonsterDamage()
    {
        Random random = new Random();
        int damage = random.Next(10, 25);
        return damage;
    }
}
