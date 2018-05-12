namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_programms : mdl_entity_base
    {
        public string name { get; set; }
        public string code { get; set; }
        public string about { get; set; }
        public string status { get; set; }
        public long? departmentid { get; set; }
        public string notice { get; set; }
        public short? agenums { get; set; }
        public long? duration { get; set; }
        public long? ahours { get; set; }
        public string billingtext { get; set; }
        public string billingrules { get; set; }
        public short? flowagenums { get; set; }
        public short? edulevel { get; set; }
    }
}