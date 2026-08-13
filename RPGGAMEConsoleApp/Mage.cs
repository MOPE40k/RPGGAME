namespace RPGGAMEConsoleApp;

public class Mage : Hero
{
    public Mage(string name)
        : base(name, maxHp: 80, strength: 8, agility: 10)
    {
    }

    public override string ClassName => "Маг";

    public override int Attack(Monster monster)
    {
        int damage = Strength * 3;
        monster.TakeDamage(damage, ignoreArmor: true);
        return damage;
    }
}