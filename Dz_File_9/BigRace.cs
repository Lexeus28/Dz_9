using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_File_9
{
    public class BigRace
    {
        private readonly List<IGame> _games;
        private readonly List<Team> _teams;

        public BigRace()
        {
            _games = new List<IGame>();
            _teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            _teams.Add(team);
        }

        public void AddGame(IGame game)
        {
            _games.Add(game);
        }

        public void StartCompetition()
        {
            foreach (IGame game in _games)
            {
                foreach (Team team in _teams)
                {
                    game.Play(team.Name);
                }
            }
        }
    }
}
