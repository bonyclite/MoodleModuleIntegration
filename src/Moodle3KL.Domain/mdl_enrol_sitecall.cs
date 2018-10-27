namespace Moodle3KL.Domain
{
    public class mdl_enrol_sitecall : mdl_entity_base
    {
        public long userid { get; set; }
        public long courseid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public long date { get; set; }
        public string additional { get; set; }
        public string status { get; set; }
    }
}