namespace RPGGAMEConsoleApp
{
    public class Monster
    {
        public string Name { get; }
        
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Armor { get; }
        
        public bool IsAlive => Health > 0;

        public Monster(string name, int health, int strength, int armor)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Armor = armor;
        }
        
        public int Attack(Hero hero)
        {
            hero.TakeDamage(Strength);
            return Strength;
        }

        public void TakeDamage(int amount, bool ignoreArmor = false)
        {
            int real = ignoreArmor 
                ? amount 
                : amount - Armor;
            
            if (real < 0)
                real = 0;

            Health -= real;

            if (Health < 0)
                Health = 0;
        }
    }
}
