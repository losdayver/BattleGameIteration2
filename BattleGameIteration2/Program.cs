using BattleGameIteration2;
using BattleGameIteration2.Units;

class Program
{
    static void Main()
    {
        Army army1 = new( new() {
            new HeavyInfantry(),
            new LightInfantry(),
        }, "Армия 1");

        Army army2 = new(new() {
            new Archer(),
            new Archer(),
            new Archer(),
            new Archer(),
            new Archer(),
            new Archer(),
        }, "Армия 2");

        Battle battle = new(army1, army2);

        Console.WriteLine("Начальная информация о юнитах: ");
        Console.WriteLine(army1.GetInfo());
        Console.WriteLine(army2.GetInfo());
        Console.ReadKey();
        Console.WriteLine("_____________________________________________");

        while (!battle.winCondition)
        {
            Console.WriteLine($"Сейчас ходят юниты под номером: {battle.unitPointer}");
            Console.WriteLine(battle.MakeTurn());
            Console.WriteLine(army1.GetInfo());
            Console.WriteLine(army2.GetInfo());
            Console.ReadKey();
            Console.WriteLine("_____________________________________________");
        }

        Console.ReadKey();
    }
}