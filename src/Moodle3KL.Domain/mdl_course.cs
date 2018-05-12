namespace Moodle3KL.Domain
{
    public class mdl_course
    {
        public long id { get; set; }
        public long category { get; set; }
        public long sortorder { get; set; }
        public string fullname { get; set; }
        public string shortname { get; set; }
        public string idnumber { get; set; }
        public string summary { get; set; }
        public short summaryformat { get; set; }
        public string format { get; set; }
        public short showgrades { get; set; }
        public int newsitems { get; set; }
        public long startdate { get; set; }
        public long marker { get; set; }
        public long maxbytes { get; set; }
        public short legacyfiles { get; set; }
        public short showreports { get; set; }
        public short visible { get; set; }
        public short visibleold { get; set; }
        public short groupmode { get; set; }
        public short groupmodeforce { get; set; }
        public long defaultgroupingid { get; set; }
        public string lang { get; set; }
        public string calendartype { get; set; }
        public string theme { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short requested { get; set; }
        public short enablecompletion { get; set; }
        public short completionnotify { get; set; }
        public long cacherev { get; set; }
    }
}