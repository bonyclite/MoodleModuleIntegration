namespace Moodle3KL.Domain
{
    public class mdl_external_services_users : mdl_entity_base
    {
        public long externalserviceid { get; set; }
        public long userid { get; set; }
        public string iprestriction { get; set; }
        public long? validuntil { get; set; }
        public long? timecreated { get; set; }
    }
}