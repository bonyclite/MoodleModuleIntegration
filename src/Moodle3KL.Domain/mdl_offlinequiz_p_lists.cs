namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_p_lists
    {
        public long id { get; set; }
        public long offlinequizid { get; set; }
        public string name { get; set; }
        public long number { get; set; }
        public string filename { get; set; }
    }
}