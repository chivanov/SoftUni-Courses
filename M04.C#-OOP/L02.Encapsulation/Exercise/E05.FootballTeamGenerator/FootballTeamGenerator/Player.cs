using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private readonly int endurance;
        private readonly int sprint;
        private readonly int dribble;
        private readonly int passing;
        private readonly int shooting;

        public Player(
            string name,
            int endurance,
            int sprint,
            int dribble,
            int passing,
            int shooting)
        {
            this.Name = name;

            ValidateStat("Endurance", endurance);
            ValidateStat("Sprint", sprint);
            ValidateStat("Dribble", dribble);
            ValidateStat("Passing", passing);
            ValidateStat("Shooting", shooting);

            this.endurance = endurance;
            this.sprint = sprint;
            this.dribble = dribble;
            this.passing = passing;
            this.shooting = shooting;
        }     

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public double Stats
            => (this.endurance + this.sprint + this.dribble + this.passing + this.shooting) / 5.0;

        private void ValidateStat(string name, int endurance)
        {
            if (endurance < 0 || endurance > 100)
            {
                throw new ArgumentException($"{name} should be between 0 and 100.");
            }
        }
    }
}
