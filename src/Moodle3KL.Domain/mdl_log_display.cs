namespace Moodle3KL.Domain
{
    public class mdl_log_display : mdl_entity_base
    {
        public string module { get; set; }
        public string action { get; set; }
        public string mtable { get; set; }
        public string field { get; set; }
        public string component { get; set; }
    }
}