using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace modul3Oblig1
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;
        
                       
        public string GetDescription()
        {
            
            string InfoFound = CheckIfExist();

            return InfoFound;
        }

        public string CheckIfExist()
        {
            string toReturn = "";

            if(FirstName != null)
            {
                toReturn += FirstName + " ";
            }
            if (LastName != null)
            {
                toReturn += LastName + " ";
            }
            if (Id != 0)
            {
                toReturn += "(Id=" + Id + ")";
            }
            if (BirthYear != 0)
            {
                toReturn += " Født: " + BirthYear;
            }
            if (DeathYear != 0)
            {
                toReturn += " Død: " + DeathYear;
            }
            if (Father != null)
            {
                toReturn += " Far: " + Father.FirstName + " (Id=" + Father.Id + ")";
            }
            if (Mother != null)
            {
                toReturn += " Mor: " + Mother.FirstName + " (Id=" + Mother.Id + ")";
            }

            return toReturn;
        }        
    }    
}
