namespace RPGGAMEConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Рагнар", 100, 15, 5, 8);
            DisplayHeroStats(hero1);
            
            Console.WriteLine("Получаем урон: 110 очков");
            hero1.TakeDamage(110);
            DisplayHeroStats(hero1);

            Console.WriteLine("Лучимся: 220 очков");
            hero1.Heal(220);
            DisplayHeroStats(hero1);

            var goblin = new Monster("Гоблин", health: 30, armor: 3);
            Console.WriteLine($"Из темноты выходит {goblin.Name} (Здоровье: {goblin.Health}, Броня: {goblin.Armor})");

            var ork = new Monster("Орк", health: 70, armor: 7);
            Console.WriteLine($"Следом выходит {ork.Name} (Здоровье: {ork.Health}, Броня: {ork.Armor})");
        }

        static void DisplayHeroStats(Hero hero)
        {
            Console.WriteLine($"Имя героя: {hero.Name}");
            Console.WriteLine($"Здоровье: {hero.CurrentHp}");
            Console.WriteLine($"Сила: {hero.Strength}");
            Console.WriteLine($"Ловкость: {hero.Agility}");
            Console.WriteLine($"Счет: {hero.Score}");
            Console.WriteLine($"Жив: {hero.IsAlive}");
        }
    }
}
