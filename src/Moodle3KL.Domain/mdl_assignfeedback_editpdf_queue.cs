namespace Moodle3KL.Domain
{
    public class mdl_assignfeedback_editpdf_queue : mdl_entity_base {
        public long submissionid { get; set; }
        public long submissionattempt { get; set; }
    }
}