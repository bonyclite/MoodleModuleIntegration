namespace Moodle3KL.Domain
{
    public class mdl_task_adhoc
    {
        public long id { get; set; }
        public string component { get; set; }
        public string classname { get; set; }
        public long nextruntime { get; set; }
        public long? faildelay { get; set; }
        public string customdata { get; set; }
        public short blocking { get; set; }
    }
}