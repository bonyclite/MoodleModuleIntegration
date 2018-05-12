namespace Moodle3KL.Domain
{
    public class mdl_feedback_sitecourse_map : mdl_entity_base {
        public long feedbackid { get; set; }
        public long courseid { get; set; }
    }
}