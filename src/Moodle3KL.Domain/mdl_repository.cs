namespace Moodle3KL.Domain
{
    public class mdl_repository : mdl_entity_base
    {
        public string type { get; set; }
        public short? visible { get; set; }
        public long sortorder { get; set; }
    }
}