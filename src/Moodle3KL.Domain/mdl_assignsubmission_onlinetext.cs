namespace Moodle3KL.Domain
{
    public class mdl_assignsubmission_onlinetext : mdl_entity_base
    {
        public long assignment { get; set; }
        public long submission { get; set; }
        public string onlinetext { get; set; }
        public short onlineformat { get; set; }
    }
}