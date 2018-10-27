namespace Moodle3KL.Domain
{
    public class mdl_blog_association : mdl_entity_base
    {
        public long contextid { get; set; }
        public long blogid { get; set; }
    }
}