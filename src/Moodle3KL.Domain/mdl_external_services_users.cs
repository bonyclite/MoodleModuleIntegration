namespace Moodle3KL.Domain
{
    public class mdl_external_services_users
    {
        public long id { get; set; }
        public long externalserviceid { get; set; }
        public long userid { get; set; }
        public string iprestriction { get; set; }
        public long? validuntil { get; set; }
        public long? timecreated { get; set; }
    }
}