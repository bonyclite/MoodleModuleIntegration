namespace Moodle3KL.Domain
{
    public class mdl_grading_definitions : mdl_entity_base {
        public long areaid { get; set; }
        public string method { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public short? descriptionformat { get; set; }
        public long status { get; set; }
        public long? copiedfromid { get; set; }
        public long timecreated { get; set; }
        public long usercreated { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
        public long? timecopied { get; set; }
        public string options { get; set; }
    }
}