namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_cpgrades : mdl_entity_base
    {
        public long? cpassedid { get; set; }
        public long? planid { get; set; }
        public string grade { get; set; }
        public long? date { get; set; }
        public string notice { get; set; }
        public string typesync { get; set; }
        public long? mdlinstance { get; set; }
        public long? orderid { get; set; }
        public long? teacherid { get; set; }
        public string status { get; set; }
    }
}