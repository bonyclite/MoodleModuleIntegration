namespace Moodle3KL.Domain
{
    public class mdl_workshop_submissions
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public short? example { get; set; }
        public long authorid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public short contentformat { get; set; }
        public short contenttrust { get; set; }
        public short? attachment { get; set; }
        public decimal? grade { get; set; }
        public decimal? gradeover { get; set; }
        public long? gradeoverby { get; set; }
        public string feedbackauthor { get; set; }
        public short? feedbackauthorformat { get; set; }
        public long? timegraded { get; set; }
        public short? published { get; set; }
        public short late { get; set; }
    }
}