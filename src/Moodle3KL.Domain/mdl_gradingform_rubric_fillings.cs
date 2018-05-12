namespace Moodle3KL.Domain
{
    public class mdl_gradingform_rubric_fillings : mdl_entity_base {
        public long instanceid { get; set; }
        public long criterionid { get; set; }
        public long? levelid { get; set; }
        public string remark { get; set; }
        public short? remarkformat { get; set; }
    }
}