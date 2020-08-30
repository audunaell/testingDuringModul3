using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Text;

namespace OOPusingStrictConst
{
    public class BySystem
    {
        public string RpgSystemName;
        private List<Games> _listOfGames;

        public BySystem(params Games[] ListOfGames)
        {
            _listOfGames = new List<Games>(ListOfGames);
        }

        public void PrintListOfGames()
        {
            Console.WriteLine(RpgSystemName);
            foreach (var Game in _listOfGames)
            {
                Console.WriteLine(Game.NameOfTheGame());
            }
            Console.WriteLine();
        }
    }
}
