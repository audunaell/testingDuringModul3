using System;

namespace OOPusingStrictConst
{
    class Program
    {
        static void Main(string[] args)
        {
            Games Conan = new Games("Conan: Adventures in an age undreamed of", "Fantasy");
            Games MutantChronicles = new Games("MutantChronicles", "Techno fantasy diesel punk");
            Games Infinity = new Games("Infinity", "Sci-fi");
            Games CallOfCthulhu = new Games("Call of Cthulhu", "Horror");
            Games Deadlands = new Games("Deadlands", "Western");
            Games DeadlandsLostColony = new Games("Deadlands: Lost Colony", "Sci-fi");

            BySystem The2d20Games = new BySystem(Conan, MutantChronicles, Infinity);
            The2d20Games.RpgSystemName = "2d20";
            The2d20Games.PrintListOfGames();

            BySystem SavageWorlds = new BySystem(Deadlands, DeadlandsLostColony);
            SavageWorlds.RpgSystemName = "Savage Worlds";
            SavageWorlds.PrintListOfGames();
        }
    }
}
