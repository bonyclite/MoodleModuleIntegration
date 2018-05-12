namespace Moodle3KL.Domain
{
    public class mdl_assign_user_flags
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long assignment { get; set; }
        public long locked { get; set; }
        public short mailed { get; set; }
        public long extensionduedate { get; set; }
        public string workflowstate { get; set; }
        public long allocatedmarker { get; set; }
    }
}