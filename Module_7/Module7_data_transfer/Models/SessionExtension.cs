using Newtonsoft.Json;

namespace Module7_data_transfer.Models
{
    public static class SessionExtension
    {
        public static void SetObject<C>(this ISession session, string key, C value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static C GetObject<C>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return (string.IsNullOrEmpty(value)) ? default(C) :
                JsonConvert.DeserializeObject<C>(value);
        }
    }
}
