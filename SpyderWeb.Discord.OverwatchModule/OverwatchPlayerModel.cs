using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpyderWeb.Discord.OverwatchModule
{
    public class OverwatchPlayerModel
    {
        public string CompetitiveRankImageUrl { get; set; }
        public List<Achievement> Achievements { get; set; }
        public Stat CompetitiveStats { get; set; }
        public Stat CasualStats { get; set; }
        public bool IsProfilePrivate { get; set; }
        public Dictionary<Endorsement, decimal> Endorsements { get; set; }
        public ushort EndorsementLevel { get; set; }
        public ushort CompetitiveRank { get; set; }
        public string PlayerLevelImage { get; set; }
        public ushort PlayerLevel { get; set; }
        public string ProfileUrl { get; set; }
        public string PlayerId { get; set; }
        public List<Alias> Aliases { get; set; }
        public Platform GamePlatform { get; set; }
        public string Username { get; set; }
        public string ProfilePortraitUrl { get; set; }
        public long GamesWon { get; set; }
        public string EndorsementImage { get; set; }
        public Uri PrestigeImage { get; set; }
        public ushort Prestige { get; set; }

        public sealed class Alias
        {
            public Platform Platform { get; set; }
            public string Username { get; set; }
            public Visibility ProfileVisibility { get; set; }
        }

        public sealed class Achievement
        {
            public string CategoryName { get; set; }
            public string Name { get; set; }
            public bool IsEarned { get; set; }
        }

        public sealed class Stat
        {
            public ICollection<StatValue> TopHeroes { get; set; }
            public ICollection<StatValue> CareerStats { get; set; }
        }
        public sealed class StatValue
        {
            public string HeroName { get; set; }
            public string CategoryName { get; set; }
            public string Name { get; set; }
            public dynamic Value { get; set; }
        }

        public enum Endorsement
        {
            Shotcaller = 0,
            GoodTeammate = 1,
            Sportsmanship = 2
        }

        public enum Platform
        {
            Pc = 0,
            Xbl = 1,
            Psn = 2
        }

        public enum Visibility
        {
            Private = 0,
            FriendsOnly = 1,
            Public = 2
        }
    }
}
