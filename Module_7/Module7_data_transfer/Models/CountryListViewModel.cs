namespace Module7_data_transfer.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public string UserName { get; set; }
        public List<Country> Country { get; set; }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = new List<Category>
                {
                    new Category { CategoryID = "all", Name = "All"}
                };

                categories.AddRange(value);
            }
        }
        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = new List<Game>
                {
                    new Game { GameID = "all", Name = "All"}
                };

                games.AddRange(value);
            }
        }

        public string CheckActiveCat(string c) =>
                c.ToLower() == ActiveCat.ToLower() ? "active" : "";

        public string CheckActiveGame(string g) =>
            g.ToLower() == ActiveGame.ToLower() ? "active" : "";
    }
}
