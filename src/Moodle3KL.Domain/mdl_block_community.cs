namespace Moodle3KL.Domain
{
    public class mdl_block_community : mdl_entity_base
    {
        public long userid { get; set; }
        public string coursename { get; set; }
        public string coursedescription { get; set; }
        public string courseurl { get; set; }
        public string imageurl { get; set; }
    }
}