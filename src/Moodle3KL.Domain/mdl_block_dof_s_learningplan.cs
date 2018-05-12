namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_learningplan
    {
        public long id { get; set; }
        public string type { get; set; }
        public long? programmsbcid { get; set; }
        public long? agroupid { get; set; }
        public short agenum { get; set; }
        public long programmitemid { get; set; }
        public long? appointmentid { get; set; }
    }
}