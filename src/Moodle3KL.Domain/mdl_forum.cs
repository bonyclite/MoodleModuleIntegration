namespace Moodle3KL.Domain
{
    public class mdl_forum : mdl_entity_base {
        public long course { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long assessed { get; set; }
        public long assesstimestart { get; set; }
        public long assesstimefinish { get; set; }
        public long scale { get; set; }
        public long maxbytes { get; set; }
        public long maxattachments { get; set; }
        public short forcesubscribe { get; set; }
        public short trackingtype { get; set; }
        public short rsstype { get; set; }
        public short rssarticles { get; set; }
        public long timemodified { get; set; }
        public long warnafter { get; set; }
        public long blockafter { get; set; }
        public long blockperiod { get; set; }
        public int completiondiscussions { get; set; }
        public int completionreplies { get; set; }
        public int completionposts { get; set; }
        public short displaywordcount { get; set; }
    }
}