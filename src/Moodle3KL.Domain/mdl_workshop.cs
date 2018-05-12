namespace Moodle3KL.Domain
{
    public class mdl_workshop : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string instructauthors { get; set; }
        public short instructauthorsformat { get; set; }
        public string instructreviewers { get; set; }
        public short instructreviewersformat { get; set; }
        public long timemodified { get; set; }
        public short? phase { get; set; }
        public short? useexamples { get; set; }
        public short? usepeerassessment { get; set; }
        public short? useselfassessment { get; set; }
        public decimal? grade { get; set; }
        public decimal? gradinggrade { get; set; }
        public string strategy { get; set; }
        public string evaluation { get; set; }
        public short? gradedecimals { get; set; }
        public short? nattachments { get; set; }
        public string submissionfiletypes { get; set; }
        public short? latesubmissions { get; set; }
        public long? maxbytes { get; set; }
        public short? examplesmode { get; set; }
        public long? submissionstart { get; set; }
        public long? submissionend { get; set; }
        public long? assessmentstart { get; set; }
        public long? assessmentend { get; set; }
        public short phaseswitchassessment { get; set; }
        public string conclusion { get; set; }
        public short conclusionformat { get; set; }
        public short? overallfeedbackmode { get; set; }
        public short? overallfeedbackfiles { get; set; }
        public string overallfeedbackfiletypes { get; set; }
        public long? overallfeedbackmaxbytes { get; set; }
    }
}