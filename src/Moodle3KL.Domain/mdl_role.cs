namespace Moodle3KL.Domain
{
    public class mdl_role : mdl_entity_base
    {
        public string name { get; set; }
        public string shortname { get; set; }
        public string description { get; set; }
        public long sortorder { get; set; }
        public string archetype { get; set; }
    }
}