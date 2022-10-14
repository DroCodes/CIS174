namespace Module7_data_transfer.Models
{
    public class CountrySession
    {
        private const string CountryKey = "mycountry";
        private const string CountKey = "countrycount";
        private const string CatKey = "cat";
        private const string GameKey = "game";

        private ISession session { get; set; }
        public CountrySession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCountry(List<Country> country)
        {
            session.SetObject(CountryKey, country);
            session.SetInt32(CountKey, country.Count);
        }
        public List<Country> GetMyCountry() =>
            session.GetObject<List<Country>>(CountryKey) ?? new List<Country>();
        public int? GetMyCountryCount() => session.GetInt32(CountKey) ?? 0;

        public void SetActiveCat(string activeCat) =>
            session.SetString(CatKey, activeCat);
        public string GetActiveCat() => session.GetString(CatKey);

        public void SetActiveGame(string activeGame) => 
            session.SetString(GameKey, activeGame);
        public string GetActiveGame() => session.GetString(GameKey);

        public void RemoveMyCountry()
        {
            session.Remove(CountryKey);
            session.Remove(CountKey);
        }
    }
}
