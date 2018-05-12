namespace Moodle3KL.Domain
{
    public class mdl_qtype_essay_options : mdl_entity_base
    {
        public long questionid { get; set; }
        public string responseformat { get; set; }
        public short responserequired { get; set; }
        public short responsefieldlines { get; set; }
        public short attachments { get; set; }
        public short attachmentsrequired { get; set; }
        public string graderinfo { get; set; }
        public short graderinfoformat { get; set; }
        public string responsetemplate { get; set; }
        public short responsetemplateformat { get; set; }
    }
}