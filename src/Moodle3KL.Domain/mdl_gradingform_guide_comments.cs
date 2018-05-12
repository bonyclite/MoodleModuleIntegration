namespace Moodle3KL.Domain
{
    public class mdl_gradingform_guide_comments
    {
        public long id { get; set; }
        public long definitionid { get; set; }
        public long sortorder { get; set; }
        public string description { get; set; }
        public short? descriptionformat { get; set; }
    }
}