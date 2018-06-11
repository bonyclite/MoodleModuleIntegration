namespace Moodle3KL.Domain
{
    public class mdl_study_document : mdl_entity_base
    {
        public long studentid { get; set; }
        public long departmentid { get; set; }
        public bool isnew { get; set; }
        public bool isapproved { get; set; }
    }
}