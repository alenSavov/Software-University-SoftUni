﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
   public class Game
    {
        public Game()
        {
            Bets = new HashSet<Bet>();
            PlayerStatistics = new HashSet<PlayerStatistic>();
        }

        public int GameId { get; set; }
        
        public DateTime DateTime { get; set; }

        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        public byte HomeTeamGoals { get; set; }
        public float HomeTeamBetRate { get; set; }


        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

        public byte AwayTeamGoals { get; set; }

        public decimal AwayTeamBetRate { get; set; }

        public float DrawBetRate { get; set; }

        public GameResult Result { get; set; }


        public ICollection<Bet> Bets { get; set; }
        public ICollection<PlayerStatistic> PlayerStatistics { get; set; }

    }
}
