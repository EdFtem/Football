﻿using System;
using System.Collections.Generic;
using System.Text;
using Football.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Football.Data.EntityFramework
{
    public class FootballContext : DbContext
    {
        public DbSet<FootballPlayer> FootballPlayers { get; set; }

        public FootballContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
