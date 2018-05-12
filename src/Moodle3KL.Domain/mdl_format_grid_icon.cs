namespace Moodle3KL.Domain
{
    public class mdl_format_grid_icon : mdl_entity_base
    {
        public string image { get; set; }
        public long displayedimageindex { get; set; }
        public long sectionid { get; set; }
        public long courseid { get; set; }
    }
}