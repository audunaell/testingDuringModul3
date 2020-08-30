using System;

namespace SimpleObjectOrientationUsingAMoreOpenConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            DailyActivities Monday = new DailyActivities { TraveledTo = "Horten", BoughtDinner = "hamburger", HobbyActivity = "spilte rollespill" };
            DailyActivities Thuesday = new DailyActivities { CompletedTask = "satte på plass saker i bokhylla", MadeDinner = "kjøttseus og spagetti"};
            DailyActivities Wednesday = new DailyActivities { TraveledTo = "Sandefjord", HobbyActivity = "spilte rollespill", BoughtDinner = "kebab pizza" };
            DailyActivities Thursday = new DailyActivities { HobbyActivity = "jobbet på en one-shot i Deadlands", MadeDinner = "tomatsuppe" };
            DailyActivities Friday = new DailyActivities { HobbyActivity = "tegnet kart for one-shot i Deadlands", MadeDinner = "kastler med bernaissaus og poteter" };
            DailyActivities Saturday = new DailyActivities { TraveledTo = "Sandefjord", CompletedTask = "vasket og ryddet i huset", MadeDinner = "fiskegrateng" };
            DailyActivities Sunday = new DailyActivities { TraveledTo = "Sandefjord", HobbyActivity = "spilte brettspill", BoughtDinner = "kebab pizza" };

            ActivitiesLastWeek WhatIDidLastWeekAsAList = new ActivitiesLastWeek(Monday, Thuesday, Wednesday, Thursday, Friday, Saturday, Sunday);

            WhatIDidLastWeekAsAList.PrintTheWeek();
        }
    }
}
