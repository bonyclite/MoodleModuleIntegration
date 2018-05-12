namespace Moodle3KL.Domain
{
    public class mdl_data_records
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long groupid { get; set; }
        public long dataid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short approved { get; set; }
    }
}