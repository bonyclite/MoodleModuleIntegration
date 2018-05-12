namespace Moodle3KL.Domain
{
    public class mdl_block_rate_course
    {
        public long id { get; set; }
        public long course { get; set; }
        public long userid { get; set; }
        public long rating { get; set; }
    }
}