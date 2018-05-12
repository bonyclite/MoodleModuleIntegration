namespace Moodle3KL.Domain
{
    public class mdl_resource : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short tobemigrated { get; set; }
        public short legacyfiles { get; set; }
        public long? legacyfileslast { get; set; }
        public short display { get; set; }
        public string displayoptions { get; set; }
        public short filterfiles { get; set; }
        public long revision { get; set; }
        public long timemodified { get; set; }
    }
}