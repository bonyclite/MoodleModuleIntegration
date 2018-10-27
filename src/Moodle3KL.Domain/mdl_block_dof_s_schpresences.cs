namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_schpresences : mdl_entity_base
    {
        public long? eventid { get; set; }
        public long? personid { get; set; }
        public string present { get; set; }
        public long? orderid { get; set; }
        public long? mdlevent { get; set; }
    }
}