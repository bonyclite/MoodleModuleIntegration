namespace Moodle3KL.Domain
{
    public class mdl_workshopform_rubric_levels
    {
        public long id { get; set; }
        public long dimensionid { get; set; }
        public decimal grade { get; set; }
        public string definition { get; set; }
        public short? definitionformat { get; set; }
    }
}