namespace RPGGAMEConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя героя: ");
            var name = Console.ReadLine();

            Console.WriteLine("Выберите класс героя:");
            Console.WriteLine("1. Воин");
            Console.WriteLine("2. Маг");
            Console.WriteLine("3. Лучник");
            Console.WriteLine("4. Священник");
            var choice = Console.ReadLine();

            Hero hero = null;
            switch (choice)
            {
                case "1":
                    hero = new Warrior(name);
                    break;
                case "2":
                    hero = new Mage(name);
                    break;
                case "3":
                    hero = new Archer(name);
                    break;
                case "4":
                    hero = new Priest(name);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    return;
            }

            DisplayHeroStats(hero);

            var goblin = new Monster("Гоблин", health: 30, strength: 3, armor: 3);
            Console.WriteLine($"Из темноты выходит {goblin.Name} (Здоровье: {goblin.Health}, Броня: {goblin.Armor})");
            
            while (true)
            {
                Console.WriteLine("Нажмите Enter, чтобы атаковать Гоблина...");
                Console.ReadLine();

                int damageToEnemy = hero.Attack(goblin);
                Console.WriteLine($"{hero.Name} наносит {damageToEnemy} урона {goblin.Name}");

                if (!goblin.IsAlive)
                {
                    Console.WriteLine($"{goblin.Name} повержен!\n{hero.Name} ПОБЕДИЛ!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{goblin.Name} (Здоровье: {goblin.Health}, Броня: {goblin.Armor})");
                }

                int damageToHero = goblin.Attack(hero);
                hero.TakeDamage(damageToHero);

                if (!hero.IsAlive)
                {
                    Console.WriteLine($"{hero.Name} повержен!\n{goblin.Name} Смеётся над вашим бездыханным телом XD");
                    break;
                }
                else
                {
                    Console.WriteLine($"{hero.Name} (Здоровье: {hero.CurrentHp})");
                }
            }
        }

        static void DisplayHeroStats(Hero hero)
        {
            Console.WriteLine($"Имя героя: {hero.Name}");
            Console.WriteLine($"Класс героя: {hero.ClassName}");
            Console.WriteLine($"Здоровье: {hero.CurrentHp}");
            Console.WriteLine($"Сила: {hero.Strength}");
            Console.WriteLine($"Ловкость: {hero.Agility}");
        }
    }
}
