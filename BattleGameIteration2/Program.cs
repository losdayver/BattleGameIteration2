using BattleGameIteration2;
using BattleGameIteration2.Units;

class Program
{
    static void Main()
    {
        Army army1 = new( new() {
            new Archer(),
            new Archer(),
            new Healer(),
            new HeavyInfantry(),
            new Knight(),
        }, "Синие");

        Army army2 = new(new() {
            new HeavyInfantry(),
            new Archer(),
            new HeavyInfantry(),
            new Healer(),
            new LightInfantry(),
        }, "Красные");

        Battle battle = new(army1, army2);

        Console.WriteLine("Начальная информация о юнитах: \n");
        Console.WriteLine(army1.GetInfo());
        Console.WriteLine(army2.GetInfo());
        Console.ReadKey();

        while (!battle.winCondition)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Сейчас ходят юниты под номером: {battle.unitPointer}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(battle.MakeTurn());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(army1.GetInfo());
            Console.WriteLine(army2.GetInfo());
            Console.ReadKey();
        }
    }
}