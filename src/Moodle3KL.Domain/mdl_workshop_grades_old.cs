namespace Moodle3KL.Domain
{
    public class mdl_workshop_grades_old
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public long assessmentid { get; set; }
        public long elementno { get; set; }
        public string feedback { get; set; }
        public short grade { get; set; }
        public string newplugin { get; set; }
        public long? newid { get; set; }
    }
}