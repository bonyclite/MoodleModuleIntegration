namespace Moodle3KL.Domain
{
    public class mdl_hotpot
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string sourcefile { get; set; }
        public string sourcetype { get; set; }
        public short sourcelocation { get; set; }
        public string configfile { get; set; }
        public short configlocation { get; set; }
        public long entrycm { get; set; }
        public int entrygrade { get; set; }
        public short entrypage { get; set; }
        public string entrytext { get; set; }
        public short entryformat { get; set; }
        public short exitpage { get; set; }
        public long entryoptions { get; set; }
        public string exittext { get; set; }
        public short exitformat { get; set; }
        public long exitoptions { get; set; }
        public long exitcm { get; set; }
        public int exitgrade { get; set; }
        public string outputformat { get; set; }
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
        public long timeopen { get; set; }
        public long timeclose { get; set; }
        public long timelimit { get; set; }
        public long delay1 { get; set; }
        public long delay2 { get; set; }
        public long delay3 { get; set; }
        public string password { get; set; }
        public string subnet { get; set; }
        public long reviewoptions { get; set; }
        public int attemptlimit { get; set; }
        public short grademethod { get; set; }
        public long gradeweighting { get; set; }
        public short clickreporting { get; set; }
        public short discarddetails { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public decimal completionmingrade { get; set; }
        public short completionpass { get; set; }
        public short completioncompleted { get; set; }
    }
}