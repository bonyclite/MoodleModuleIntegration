namespace Moodle3KL.Domain
{
    public class mdl_checklist
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short? useritemsallowed { get; set; }
        public short? teacheredit { get; set; }
        public string theme { get; set; }
        public short? duedatesoncalendar { get; set; }
        public short? teachercomments { get; set; }
        public long maxgrade { get; set; }
        public short? autopopulate { get; set; }
        public short? autoupdate { get; set; }
        public long? completionpercent { get; set; }
        public short? emailoncomplete { get; set; }
        public short? lockteachermarks { get; set; }
    }
}