namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_programmsbcs : mdl_entity_base {
        public long? contractid { get; set; }
        public long? programmid { get; set; }
        public string edutype { get; set; }
        public string eduform { get; set; }
        public string freeattendance { get; set; }
        public long? agroupid { get; set; }
        public short? agenum { get; set; }
        public long? departmentid { get; set; }
        public string status { get; set; }
        public long? datestart { get; set; }
        public long? dateadd { get; set; }
        public string certificatenum { get; set; }
        public string certificateform { get; set; }
        public long? certificatedate { get; set; }
        public long? certificateorderid { get; set; }
        public long? dateend { get; set; }
        public double salfactor { get; set; }
    }
}