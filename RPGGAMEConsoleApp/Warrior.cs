namespace RPGGAMEConsoleApp;

public class Warrior : Hero
{
    public Warrior(string name)
        : base(name, maxHp: 120, strength: 15, agility: 8)
    {
    }

    public override string ClassName => "Воин";

    public override int Attack(Monster monster)
    {
        int damage = Strength * 2;
        monster.TakeDamage(damage);
        return damage;
    }
}