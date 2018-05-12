namespace Moodle3KL.Domain
{
    public class mdl_modules
    {
        public long id { get; set; }
        public string name { get; set; }
        public long cron { get; set; }
        public long lastcron { get; set; }
        public string search { get; set; }
        public short visible { get; set; }
    }
}