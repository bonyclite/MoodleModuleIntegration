namespace Moodle3KL.Domain
{
    public class mdl_lock_db : mdl_entity_base
    {
        public string resourcekey { get; set; }
        public long? expires { get; set; }
        public string owner { get; set; }
    }
}