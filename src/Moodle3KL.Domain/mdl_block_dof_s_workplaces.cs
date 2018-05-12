namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_workplaces : mdl_entity_base {
        public long? personid { get; set; }
        public long? organizationid { get; set; }
        public string statuswork { get; set; }
        public string post { get; set; }
        public long? receptiondate { get; set; }
        public long? dismissaldate { get; set; }
        public string phonework { get; set; }
        public string addnumber { get; set; }
        public string comment { get; set; }
    }
}