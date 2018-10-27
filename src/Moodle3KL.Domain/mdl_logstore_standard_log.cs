namespace Moodle3KL.Domain
{
    public class mdl_logstore_standard_log : mdl_entity_base
    {
        public string eventname { get; set; }
        public string component { get; set; }
        public string action { get; set; }
        public string target { get; set; }
        public string objecttable { get; set; }
        public long? objectid { get; set; }
        public string crud { get; set; }
        public short edulevel { get; set; }
        public long contextid { get; set; }
        public long contextlevel { get; set; }
        public long contextinstanceid { get; set; }
        public long userid { get; set; }
        public long? courseid { get; set; }
        public long? relateduserid { get; set; }
        public short anonymous { get; set; }
        public string other { get; set; }
        public long timecreated { get; set; }
        public string origin { get; set; }
        public string ip { get; set; }
        public long? realuserid { get; set; }
    }
}