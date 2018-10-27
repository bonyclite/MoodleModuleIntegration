namespace Moodle3KL.Domain
{
    public class mdl_task_scheduled : mdl_entity_base
    {
        public string component { get; set; }
        public string classname { get; set; }
        public long? lastruntime { get; set; }
        public long? nextruntime { get; set; }
        public short blocking { get; set; }
        public string minute { get; set; }
        public string hour { get; set; }
        public string day { get; set; }
        public string month { get; set; }
        public string dayofweek { get; set; }
        public long? faildelay { get; set; }
        public short customised { get; set; }
        public short disabled { get; set; }
    }
}