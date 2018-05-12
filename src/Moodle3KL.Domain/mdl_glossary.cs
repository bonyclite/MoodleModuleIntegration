namespace Moodle3KL.Domain
{
    public class mdl_glossary
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short allowduplicatedentries { get; set; }
        public string displayformat { get; set; }
        public short mainglossary { get; set; }
        public short showspecial { get; set; }
        public short showalphabet { get; set; }
        public short showall { get; set; }
        public short allowcomments { get; set; }
        public short allowprintview { get; set; }
        public short usedynalink { get; set; }
        public short defaultapproval { get; set; }
        public string approvaldisplayformat { get; set; }
        public short globalglossary { get; set; }
        public short entbypage { get; set; }
        public short editalways { get; set; }
        public short rsstype { get; set; }
        public short rssarticles { get; set; }
        public long assessed { get; set; }
        public long assesstimestart { get; set; }
        public long assesstimefinish { get; set; }
        public long scale { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public int completionentries { get; set; }
    }
}