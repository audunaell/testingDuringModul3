using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOPusingStrictConst
{
    public class Games
    {
        private string _nameOfRpg;
        private string _genre;

        public Games(string NameOfRpg, string Genre)
        {
            _nameOfRpg = NameOfRpg;
            _genre = Genre;
        }
        public string NameOfTheGame()
        {
            string TheName = "Name of the game: " + _nameOfRpg + ". Genre: " + _genre;
            return TheName;
        }
    }
}
