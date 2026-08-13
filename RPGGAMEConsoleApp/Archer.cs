namespace RPGGAMEConsoleApp;

public class Archer : Hero
{
    private const int CritHitChance = 25;
    
    public Archer(string name)
        : base(name, maxHp: 90, strength: 10, agility: 15)
    {
    }

    public override string ClassName => "Лучник";


    public override int Attack(Monster monster)
    {
        int damage = Strength / 2 + Agility;

        // 25% шанс нанести критический удар, удваивающий урон
        Random random = new Random();
        if (random.Next(100) < CritHitChance)
        {
            Console.WriteLine($"Вам удалось провести критический удар на {damage} очков урона!");
            damage *= 2;
        }

        monster.TakeDamage(damage);
        return damage;
    }
}