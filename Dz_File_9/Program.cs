using Dz_File_9;
using System;
namespace Dz_File_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Task();
        }
        static void Task()
        {
            Team teamRussia = new Team("Россия");
            Team teamFrance = new Team("Франция");
            Team teamChina = new Team("Китай");
            Team teamKazakhstan = new Team("Казахстан");

            BigRace bigRace = new BigRace();
            bigRace.AddTeam(teamRussia);
            bigRace.AddTeam(teamFrance);
            bigRace.AddTeam(teamChina);
            bigRace.AddTeam(teamKazakhstan);

            bigRace.AddGame(new BeachGame());
            bigRace.AddGame(new MouseTrapGame());
            bigRace.AddGame(new SeaGame());
            bigRace.AddGame(new FishingGame());
            bigRace.AddGame(new PostmenGame());
            bigRace.AddGame(new SlideGame());
            bigRace.AddGame(new ObstacleCourseGame());
            bigRace.StartCompetition();
        }
    }
}