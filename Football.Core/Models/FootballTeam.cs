namespace Football.Core.Models
{
    public class FootballTeam
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Rating { get; set; }

        public FootballCoach FootballCoach { get; set; }

        public FootballStadiums FootballStadiums { get; set; }
    }
}
