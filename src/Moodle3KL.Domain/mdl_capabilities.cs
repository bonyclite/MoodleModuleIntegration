namespace Moodle3KL.Domain
{
    public class mdl_capabilities
    {
        public long id { get; set; }
        public string name { get; set; }
        public string captype { get; set; }
        public long contextlevel { get; set; }
        public string component { get; set; }
        public long riskbitmask { get; set; }
    }
}