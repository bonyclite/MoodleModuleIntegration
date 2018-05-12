namespace Moodle3KL.Domain
{
    public class mdl_tag : mdl_entity_base {
        public long userid { get; set; }
        public long tagcollid { get; set; }
        public string name { get; set; }
        public string rawname { get; set; }
        public short isstandard { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public short? flag { get; set; }
        public long? timemodified { get; set; }
    }
}