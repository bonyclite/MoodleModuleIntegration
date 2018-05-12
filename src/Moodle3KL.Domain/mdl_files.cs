namespace Moodle3KL.Domain
{
    public class mdl_files : mdl_entity_base {
        public string contenthash { get; set; }
        public string pathnamehash { get; set; }
        public long contextid { get; set; }
        public string component { get; set; }
        public string filearea { get; set; }
        public long itemid { get; set; }
        public string filepath { get; set; }
        public string filename { get; set; }
        public long? userid { get; set; }
        public long filesize { get; set; }
        public string mimetype { get; set; }
        public long status { get; set; }
        public string source { get; set; }
        public string author { get; set; }
        public string license { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long sortorder { get; set; }
        public long? referencefileid { get; set; }
    }
}