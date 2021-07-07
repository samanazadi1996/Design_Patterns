namespace Singleton
{
    public class Settings
    {
        private Settings()
        {

        }
        public string Key { get; set; }
        public string Value { get; set; }

        private static Settings settings = new Settings();
        public static Settings GetInstance()
        {
            return settings;
        }
    }
}
