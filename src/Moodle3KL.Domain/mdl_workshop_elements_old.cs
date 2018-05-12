namespace Moodle3KL.Domain
{
    public class mdl_workshop_elements_old
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public short elementno { get; set; }
        public string description { get; set; }
        public short scale { get; set; }
        public short maxscore { get; set; }
        public short weight { get; set; }
        public double stddev { get; set; }
        public long totalassessments { get; set; }
        public string newplugin { get; set; }
        public long? newid { get; set; }
    }
}