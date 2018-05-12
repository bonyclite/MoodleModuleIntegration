namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_p_lists : mdl_entity_base {
        public long offlinequizid { get; set; }
        public string name { get; set; }
        public long number { get; set; }
        public string filename { get; set; }
    }
}