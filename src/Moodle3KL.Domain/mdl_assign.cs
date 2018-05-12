namespace Moodle3KL.Domain
{
    public class mdl_assign : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short alwaysshowdescription { get; set; }
        public short nosubmissions { get; set; }
        public short submissiondrafts { get; set; }
        public short sendnotifications { get; set; }
        public short sendlatenotifications { get; set; }
        public long duedate { get; set; }
        public long allowsubmissionsfromdate { get; set; }
        public long grade { get; set; }
        public long timemodified { get; set; }
        public short requiresubmissionstatement { get; set; }
        public short completionsubmit { get; set; }
        public long cutoffdate { get; set; }
        public short teamsubmission { get; set; }
        public short requireallteammemberssubmit { get; set; }
        public long teamsubmissiongroupingid { get; set; }
        public short blindmarking { get; set; }
        public short revealidentities { get; set; }
        public string attemptreopenmethod { get; set; }
        public int maxattempts { get; set; }
        public short markingworkflow { get; set; }
        public short markingallocation { get; set; }
        public short sendstudentnotifications { get; set; }
        public short preventsubmissionnotingroup { get; set; }
    }
}