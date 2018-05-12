namespace Moodle3KL.Domain
{
    public class mdl_license : mdl_entity_base
    {
        public string shortname { get; set; }
        public string fullname { get; set; }
        public string source { get; set; }
        public short enabled { get; set; }
        public long version { get; set; }
    }
}