namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_educations : mdl_entity_base
    {
        public long personid { get; set; }
        public long? organizationid { get; set; }
        public long? edulevel { get; set; }
        public long? edydoctype { get; set; }
        public string edudoccode { get; set; }
        public string edudocserial { get; set; }
        public string edudocnum { get; set; }
        public string edudocdate { get; set; }
        public long? startdate { get; set; }
        public long? finishdate { get; set; }
        public string comment { get; set; }
    }
}