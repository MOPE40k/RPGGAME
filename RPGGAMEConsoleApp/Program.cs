namespace RPGGAMEConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Рагнар", 100, 15, 5, 8);
            DisplayHeroStats(hero1);

            var goblin = new Monster("Гоблин", health: 30, armor: 3);
            Console.WriteLine($"Из темноты выходит {goblin.Name} (Здоровье: {goblin.Health}, Броня: {goblin.Armor})");
        }

        static void DisplayHeroStats(Hero hero)
        {
            Console.WriteLine($"Имя героя: {hero.Name}");
            Console.WriteLine($"Здоровье: {hero.Hp}");
            Console.WriteLine($"Сила: {hero.Strength}");
            Console.WriteLine($"Ловкость: {hero.Agility}");
            Console.WriteLine($"Счет: {hero.Score}");
        }
    }
}
