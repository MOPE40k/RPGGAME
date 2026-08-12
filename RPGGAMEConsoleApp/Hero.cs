namespace RPGGAMEConsoleApp
{
    public class Hero
    {
        public string Name { get; private set; }
        public int MaxHp { get; private set; }
        public int CurrentHp { get; private set; }
        public int Strength { get; private set; }
        public int Agility { get; private set; }
        public int Score { get; private set; }
        public bool IsAlive => CurrentHp > 0;

        public Hero(string name, int maxHp, int strength, int agility, int score)
        {
            Name = name;
            MaxHp = maxHp;
            Strength = strength;
            Agility = agility;
            Score = score;

            CurrentHp = maxHp;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Урон не может быть отрицательным!");

            CurrentHp -= damage;
            if (CurrentHp < 0)
                CurrentHp = 0;
        }

        public void Heal(int heal)
        {
            if (heal < 0)
                throw new ArgumentException("Количество очков здоровья для лечения не может быть отрицательным!");
            
            CurrentHp += heal;
            if (CurrentHp > MaxHp)
                CurrentHp = MaxHp;
        }
    }
}
