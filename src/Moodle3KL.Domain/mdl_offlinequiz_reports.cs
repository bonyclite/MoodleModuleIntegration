namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_reports
    {
        public long id { get; set; }
        public string name { get; set; }
        public long displayorder { get; set; }
        public long lastcron { get; set; }
        public long cron { get; set; }
        public string capability { get; set; }
    }
}