namespace Moodle3KL.Domain
{
    public class mdl_feedback_template
    {
        public long id { get; set; }
        public long course { get; set; }
        public short ispublic { get; set; }
        public string name { get; set; }
    }
}