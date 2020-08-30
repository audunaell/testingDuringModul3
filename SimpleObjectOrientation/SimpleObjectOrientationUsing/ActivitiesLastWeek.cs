using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Unicode;

namespace SimpleObjectOrientationUsingAMoreOpenConstructor
{
    public class ActivitiesLastWeek
    {
        private List<DailyActivities> _whatIDidLastWeek;

        public ActivitiesLastWeek(params DailyActivities[] ListOfActivitiesLastWeek)
        {
            _whatIDidLastWeek = new List<DailyActivities>(ListOfActivitiesLastWeek);
        }

        public void PrintTheWeek()
        {
            string[] Weekdays = { "Måndag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag" };
            for (int i = 0; i <_whatIDidLastWeek.Count; i++)
            {
                string TheDay = Weekdays[i] + ": ";
                if (_whatIDidLastWeek[i].TraveledTo != null)
                {
                    TheDay += "tok en tur til " + _whatIDidLastWeek[i].TraveledTo + " og ";
                }
                else
                {
                    TheDay += " var hjemme og ";
                }
                if (_whatIDidLastWeek[i].CompletedTask != null)
                {
                    TheDay += _whatIDidLastWeek[i].CompletedTask + ", ";
                }
                if (_whatIDidLastWeek[i].HobbyActivity != null)
                {
                    TheDay += _whatIDidLastWeek[i].HobbyActivity + ", ";
                }
                if (_whatIDidLastWeek[i].MadeDinner != null)
                {
                    TheDay += " laget " + _whatIDidLastWeek[i].MadeDinner + " til middag.";
                }
                if (_whatIDidLastWeek[i].BoughtDinner != null)
                {
                    TheDay += " kjøpte " + _whatIDidLastWeek[i].BoughtDinner + " til middag.";
                }
                Console.WriteLine(TheDay);
            }
        }
    }
}
