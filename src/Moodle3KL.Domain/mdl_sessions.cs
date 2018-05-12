namespace Moodle3KL.Domain
{
    public class mdl_sessions : mdl_entity_base
    {
        public long state { get; set; }
        public string sid { get; set; }
        public long userid { get; set; }
        public string sessdata { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string firstip { get; set; }
        public string lastip { get; set; }
    }
}