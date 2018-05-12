namespace Moodle3KL.Domain
{
    public class mdl_qtype_ddmarker_drops
    {
        public long id { get; set; }
        public long questionid { get; set; }
        public long no { get; set; }
        public string shape { get; set; }
        public string coords { get; set; }
        public long choice { get; set; }
    }
}