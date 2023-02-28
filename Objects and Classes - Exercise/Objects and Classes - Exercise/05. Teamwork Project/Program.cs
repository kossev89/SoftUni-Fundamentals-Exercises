using System.Diagnostics.CodeAnalysis;

int teamsCount = int.Parse(Console.ReadLine());
List<Team> teams = new List<Team>();

for (int i = 0; i < teamsCount;i++)
{
    string[] createTeam = Console.ReadLine()
        .Split('-', StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string creator = createTeam[0];
    string teamName = createTeam[1];
    List<string> members = new List<string>();
    if (teams.Select(x => x.Name).Contains(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }
    if (teams.Select(x => x.Creator).Contains(creator))
    {
        Console.WriteLine($"{creator} cannot create another team!");
        continue;
    }
    Team team = new Team(creator, teamName);
    Team.TeamCreated(creator, teamName);
    teams.Add(team);
}
string assignment = Console.ReadLine();

while (assignment != "end of assignment")
{
    string[] addUser = assignment
        .Split("->", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string user = addUser[0];
    string team = addUser[1];
    Team teamToJoin = teams.FirstOrDefault(x => x.Name == team);
    if (!teams.Select(x => x.Name).Contains(team))
    {
        Console.WriteLine($"Team {team} does not exist!");
        assignment = Console.ReadLine();
        continue;
    }
    if (teams.SelectMany(x => x.Members).Contains(user) || teams.Select(x => x.Creator).Contains(user))
    {
        Console.WriteLine($"Member {user} cannot join team {team}!");
        assignment = Console.ReadLine();
        continue;
    }
    teamToJoin.AddUser(user);
    assignment = Console.ReadLine();
}

var orderedList = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

List<Team> disbandedTeams = teams
    .Where(x => x.Members.Count == 0)
    .OrderBy(x => x.Name)
    .ToList();

foreach (var team1 in orderedList)
{
    if (team1.Members.Count > 0)
    {
        Console.WriteLine($"{team1.Name}");
        Console.WriteLine($"- {team1.Creator}");
        foreach (var member in team1.Members)
        {
            Console.WriteLine($"-- {member}");
        }
    }
}
Console.WriteLine("Teams to disband:");
foreach (var team in disbandedTeams)
{
    Console.WriteLine($"{team.Name}");
}

class Team
{
    public Team(string creator, string teamName)
    {
        Creator = creator;
        Name = teamName;
    }
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; } = new List<string>();

    internal void AddUser(string user)
    {
        Members.Add(user);
    }

    internal static void TeamCreated(string creator, string teamName)
    {
        Console.WriteLine($"Team {teamName} has been created by {creator}!");
    }
}