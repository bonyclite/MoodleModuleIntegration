namespace Moodle3KL.Domain
{
    public class mdl_workshop_submissions_old : mdl_entity_base
    {
        public long workshopid { get; set; }
        public long userid { get; set; }
        public string title { get; set; }
        public long timecreated { get; set; }
        public short mailed { get; set; }
        public string description { get; set; }
        public short gradinggrade { get; set; }
        public short finalgrade { get; set; }
        public short late { get; set; }
        public long nassessments { get; set; }
        public string newplugin { get; set; }
        public long? newid { get; set; }
    }
}