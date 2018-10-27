﻿namespace Football.Core.Models
{
    public class FootballPlayer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }

        public int PlayerNumber { get; set; }

        public FootballTeam FootballTeam { get; set; }
    }
}
