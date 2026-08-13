namespace RPGGAMEConsoleApp;

public class Priest : Hero
{
    private const int SelfHealChance = 35;
    public Priest(string name) 
        : base(name, 60, 5, 8)
    {
    }

    public override string ClassName => "Священник";

    public override int Attack(Monster monster)
    {
        var damage = Strength;
        
        monster.TakeDamage(damage);
        
        var r = new Random();
        if (r.Next(100) < SelfHealChance)
        {
            Console.WriteLine($"Божественное провидение вылечило вас на {damage} очков здоровья!");
            Heal(damage, this);
        }

        return damage;
    }
}