using Microsoft.EntityFrameworkCore;

namespace Module7_data_transfer.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoor", Name = "Indoor" },
                new Category { CategoryID = "outdoor", Name = "OutDoor" });

            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter-olympics", Name = "Winter Olympics" },
                new Game { GameID = "summer-olympics", Name = "Summer Olympics" },
                new Game { GameID = "parlympics", Name = "Winter Olympics" },
                new Game { GameID = "youth-olympics", Name = "Youth Olympic Games" });

            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "can", Name = "Canada", GameID = "winter-olympics", CategoryID = "indoor", FlagImage = "images/canadian_flag.png"},
                new { CountryID = "swe", Name = "Sweden", GameID = "winter-olympics", CategoryID = "indoor", FlagImage = "images/swedish_flag.png" },
                new { CountryID = "gb", Name = "Great Britain", GameID = "winter-olympics", CategoryID = "indoor", FlagImage = "images/british_flag.png" },
                new { CountryID = "jam", Name = "Jamaica", GameID = "winter-olympics", CategoryID = "outdoor", FlagImage = "images/jamaican_flag.png" },
                new { CountryID = "ita", Name = "Italy", GameID = "winter-olympics", CategoryID = "outdoor", FlagImage = "images/italian_flag.png" },
                new { CountryID = "jap", Name = "Japan", GameID = "winter-olympics", CategoryID = "outdoor", FlagImage = "images/japanese_flag.png" },
                new { CountryID = "ger", Name = "Germany", GameID = "summer-olympics", CategoryID = "indoor", FlagImage = "images/german_flag.png" },
                new { CountryID = "chi", Name = "China", GameID = "summer-olympics", CategoryID = "indoor", FlagImage = "images/chinese_flag.png" },
                new { CountryID = "mex", Name = "Mexico", GameID = "summer-olympics", CategoryID = "indoor", FlagImage = "images/mexican_flag.png" },
                new { CountryID = "bra", Name = "Brazil", GameID = "summer-olympics", CategoryID = "outdoor", FlagImage = "images/brazillian_flag.png" },
                new { CountryID = "net", Name = "Netherlands", GameID = "summer-olympics", CategoryID = "outdoor", FlagImage = "images/netherlands_flag.png" },
                new { CountryID = "usa", Name = "USA", GameID = "summer-olympics", CategoryID = "outdoor", FlagImage = "images/usa_flag.png" },
                new { CountryID = "thai", Name = "Thailand", GameID = "parlympics", CategoryID = "indoor", FlagImage = "images/thai_flag.png" },
                new { CountryID = "uru", Name = "Uruguay", GameID = "parlympics", CategoryID = "indoor", FlagImage = "images/uruguay_flag.png" },
                new { CountryID = "ukr", Name = "Ukrain", GameID = "parlympics", CategoryID = "indoor", FlagImage = "images/ukrain_flag.png" },
                new { CountryID = "aus", Name = "Australia", GameID = "parlympics", CategoryID = "outdoor", FlagImage = "images/australian_flag.png" },
                new { CountryID = "pak", Name = "Pakistan", GameID = "parlympics", CategoryID = "outdoor", FlagImage = "images/pakistan_flag.png" },
                new { CountryID = "zim", Name = "Zimbabwe", GameID = "parlympics", CategoryID = "outdoor", FlagImage = "images/zimbabwe_flag.png" },
                new { CountryID = "fra", Name = "France", GameID = "youth-olympics", CategoryID = "indoor", FlagImage = "images/french_flag.png" },
                new { CountryID = "cyp", Name = "Cyprus", GameID = "youth-olympics", CategoryID = "indoor", FlagImage = "images/cyprus_flag.png" },
                new { CountryID = "rus", Name = "Russia", GameID = "youth-olympics", CategoryID = "indoor", FlagImage = "images/russian_flag.png" },
                new { CountryID = "fin", Name = "Finland", GameID = "youth-olympics", CategoryID = "outdoor", FlagImage = "images/finnish_flag.png" },
                new { CountryID = "slov", Name = "Slovakia", GameID = "youth-olympics", CategoryID = "outdoor", FlagImage = "images/slovakian_flag.png" },
                new { CountryID = "por", Name = "Portugal", GameID = "youth-olympics", CategoryID = "outdoor", FlagImage = "images/portugese_flag.png" });
        }
    }
}
