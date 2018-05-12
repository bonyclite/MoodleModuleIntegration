namespace Moodle3KL.Domain
{
    public class mdl_workshopallocation_scheduled : mdl_entity_base
    {
        public long workshopid { get; set; }
        public short enabled { get; set; }
        public long submissionend { get; set; }
        public long? timeallocated { get; set; }
        public string settings { get; set; }
        public long? resultstatus { get; set; }
        public string resultmessage { get; set; }
        public string resultlog { get; set; }
    }
}