using System;
using System.Collections.Generic;
using System.Linq;

namespace PE05.TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = input[0];
                string teamName = input[1];

                if (teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team();

                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {

                string user = command.Split(new string[] { "->" }, StringSplitOptions.None)[0];
                string teamToJoin = command.Split(new string[] { "->" }, StringSplitOptions.None)[1];

                if (!teams.Any(team => team.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(team => team.Members.Contains(user) || teams.Any(team => team.Creator == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else
                {
                    Team currTeam = teams.First(team => team.Name == teamToJoin);
                    currTeam.Members.Add(user);
                }
                command = Console.ReadLine();
            }

            var validTeam = teams.Where(team => team.Members.Count > 0);
            var disbandedTeams = teams.Where(team => team.Members.Count == 0);

            foreach (Team team in validTeam.OrderByDescending(team => team.Members.Count).ThenBy(team => team.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (string member in team.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            if (disbandedTeams != null)
            {
                foreach (Team disbandedTeam in disbandedTeams.OrderBy(team => team.Name))
                {
                    Console.WriteLine($"{disbandedTeam.Name}");
                }
            }
        }
    }
}
