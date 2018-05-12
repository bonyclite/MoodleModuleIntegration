namespace Moodle3KL.Domain
{
    public class mdl_course_modules
    {
        public long id { get; set; }
        public long course { get; set; }
        public long module { get; set; }
        public long instance { get; set; }
        public long section { get; set; }
        public string idnumber { get; set; }
        public long added { get; set; }
        public short score { get; set; }
        public int indent { get; set; }
        public short visible { get; set; }
        public short visibleold { get; set; }
        public short groupmode { get; set; }
        public long groupingid { get; set; }
        public short completion { get; set; }
        public long? completiongradeitemnumber { get; set; }
        public short completionview { get; set; }
        public long completionexpected { get; set; }
        public short showdescription { get; set; }
        public string availability { get; set; }
    }
}