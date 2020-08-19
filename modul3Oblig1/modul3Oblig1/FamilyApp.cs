using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace modul3Oblig1
{    
    public class FamilyApp        
    {
        public List<Person> FamilyList;
        public string CommandPrompt = "Input: ";

        public FamilyApp(params Person[] persons)
        {
            FamilyList = new List<Person>(persons);
            
        }
               
        public string HandleCommand(string Command)
        {
            string Question = Command;
                            
                if (Question.ToLower() == "hjelp")
                {
                string HelpMenu = "skriv: 'hjelp' for liste over kommandoer." + "\n" +
                    "skriv: 'liste' for å se slektninger som er registrert." + "\n" +
                    "skriv: 'vis <id>' for å se personen med denne id.";                        
                    return HelpMenu;
                }
                else if (Question.ToLower() == "liste")
                {
                    string Listing = "";
                    foreach(var Persons in FamilyList)
                    {
                        Listing += Persons.GetDescription() + "\n";
                    }
                    return Listing;
                }
                else if (Question.Length > 0 && Question.Substring(0, 3).ToLower() == "vis")
                {
                    int IdNumber = Int32.Parse(Question.Substring(4));
                    return FindPerson(IdNumber);                
                }                
                else
                {
                    string WriteHelp = "skriv: 'hjelp' for liste over kommandoer ";
                    return WriteHelp;                    
                }               
        }
        public string WelcomeMessage()
        {
            string Message = "Velkommen!";
            return Message;
        }

        public string FindPerson(int IdNumber)
        {
            string InfoToReturn;

            foreach(var SearchedForPersin in FamilyList)
            {
                if(SearchedForPersin.Id == IdNumber)
                {
                    InfoToReturn = SearchedForPersin.GetDescription();                    
                    InfoToReturn += FindChildren(IdNumber);
                    return InfoToReturn;
                }
            }
            InfoToReturn = "Could not find person.";
            return InfoToReturn;
        }

        public string FindChildren(int IdNumber)
        {
            int maxChildren = FamilyList.Count;
            string[] IdListOfChildrens = new string[maxChildren];
            string child = null;
            int c = 0;

            for (int i = 0; i < maxChildren; i++){
                
                if (FamilyList[i].Mother != null && FamilyList[i].Mother.Id == IdNumber)
                {                    
                    IdListOfChildrens[c] = "    " + FamilyList[i].FirstName + " (Id=" + FamilyList[i].Id + ") Født: " + FamilyList[i].BirthYear + "\n";
                    c++;                    
                }
                else if (FamilyList[i].Father != null && FamilyList[i].Father.Id == IdNumber)
                {                    
                    IdListOfChildrens[c] = "    " + FamilyList[i].FirstName + " (Id=" + FamilyList[i].Id + ") Født: " + FamilyList[i].BirthYear + "\n";
                    c++;                    
                }
            }
            
            if(IdListOfChildrens[0] != null)
            {
                child = "\n  Barn:\n";
                for(int i = 0; i < IdListOfChildrens.Length; i++)
                {                    
                    if(IdListOfChildrens[i] != null)
                    {
                        child += IdListOfChildrens[i];
                    }                    
                }
            }
            else if (IdListOfChildrens[0] == null)
            {
                child = "";
            }

            
            return child;
        }
    }
}
