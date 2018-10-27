namespace Moodle3KL.Domain
{
    public class mdl_glossary_alias : mdl_entity_base
    {
        public long entryid { get; set; }
        public string alias { get; set; }
    }
}