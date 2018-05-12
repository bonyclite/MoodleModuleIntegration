namespace Moodle3KL.Domain
{
    public class mdl_log_display
    {
        public long id { get; set; }
        public string module { get; set; }
        public string action { get; set; }
        public string mtable { get; set; }
        public string field { get; set; }
        public string component { get; set; }
    }
}