namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_queue
    {
        public long id { get; set; }
        public long offlinequizid { get; set; }
        public long importuserid { get; set; }
        public long timecreated { get; set; }
        public long timestart { get; set; }
        public long timefinish { get; set; }
        public string status { get; set; }
    }
}