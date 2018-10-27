namespace Moodle3KL.Domain
{
    public class mdl_workshop_assessments : mdl_entity_base
    {
        public long submissionid { get; set; }
        public long reviewerid { get; set; }
        public long weight { get; set; }
        public long? timecreated { get; set; }
        public long? timemodified { get; set; }
        public decimal? grade { get; set; }
        public decimal? gradinggrade { get; set; }
        public decimal? gradinggradeover { get; set; }
        public long? gradinggradeoverby { get; set; }
        public string feedbackauthor { get; set; }
        public short? feedbackauthorformat { get; set; }
        public short? feedbackauthorattachment { get; set; }
        public string feedbackreviewer { get; set; }
        public short? feedbackreviewerformat { get; set; }
    }
}