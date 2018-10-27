namespace Moodle3KL.Domain
{
    public class mdl_assignfeedback_comments : mdl_entity_base
    {
        public long assignment { get; set; }
        public long grade { get; set; }
        public string commenttext { get; set; }
        public short commentformat { get; set; }
    }
}