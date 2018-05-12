namespace Moodle3KL.Domain
{
    public class mdl_external_tokens
    {
        public long id { get; set; }
        public string token { get; set; }
        public short tokentype { get; set; }
        public long userid { get; set; }
        public long externalserviceid { get; set; }
        public string sid { get; set; }
        public long contextid { get; set; }
        public long creatorid { get; set; }
        public string iprestriction { get; set; }
        public long? validuntil { get; set; }
        public long timecreated { get; set; }
        public long? lastaccess { get; set; }
    }
}