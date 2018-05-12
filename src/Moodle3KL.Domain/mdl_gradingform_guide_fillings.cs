namespace Moodle3KL.Domain
{
    public class mdl_gradingform_guide_fillings
    {
        public long id { get; set; }
        public long instanceid { get; set; }
        public long criterionid { get; set; }
        public string remark { get; set; }
        public short? remarkformat { get; set; }
        public decimal score { get; set; }
    }
}