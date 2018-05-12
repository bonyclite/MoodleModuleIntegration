namespace Moodle3KL.Domain
{
    public class mdl_tag_correlation : mdl_entity_base
    {
        public long tagid { get; set; }
        public string correlatedtags { get; set; }
    }
}