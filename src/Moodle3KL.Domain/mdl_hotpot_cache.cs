namespace Moodle3KL.Domain
{
    public class mdl_hotpot_cache : mdl_entity_base
    {
        public long hotpotid { get; set; }
        public string slasharguments { get; set; }
        public string hotpot_bodystyles { get; set; }
        public string hotpot_enableobfuscate { get; set; }
        public string hotpot_enableswf { get; set; }
        public string name { get; set; }
        public string sourcefile { get; set; }
        public string sourcetype { get; set; }
        public short sourcelocation { get; set; }
        public long sourcerepositoryid { get; set; }
        public string sourcelastmodified { get; set; }
        public string sourceetag { get; set; }
        public string configfile { get; set; }
        public short configlocation { get; set; }
        public long configrepositoryid { get; set; }
        public string configlastmodified { get; set; }
        public string configetag { get; set; }
        public short navigation { get; set; }
        public int title { get; set; }
        public short stopbutton { get; set; }
        public string stoptext { get; set; }
        public short allowpaste { get; set; }
        public short usefilters { get; set; }
        public short useglossary { get; set; }
        public string usemediafilter { get; set; }
        public short studentfeedback { get; set; }
        public string studentfeedbackurl { get; set; }
        public long timelimit { get; set; }
        public long delay3 { get; set; }
        public short clickreporting { get; set; }
        public string content { get; set; }
        public long timemodified { get; set; }
        public string md5key { get; set; }
    }
}