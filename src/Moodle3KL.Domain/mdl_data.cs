namespace Moodle3KL.Domain
{
    public class mdl_data : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short comments { get; set; }
        public long timeavailablefrom { get; set; }
        public long timeavailableto { get; set; }
        public long timeviewfrom { get; set; }
        public long timeviewto { get; set; }
        public int requiredentries { get; set; }
        public int requiredentriestoview { get; set; }
        public int maxentries { get; set; }
        public short rssarticles { get; set; }
        public string singletemplate { get; set; }
        public string listtemplate { get; set; }
        public string listtemplateheader { get; set; }
        public string listtemplatefooter { get; set; }
        public string addtemplate { get; set; }
        public string rsstemplate { get; set; }
        public string rsstitletemplate { get; set; }
        public string csstemplate { get; set; }
        public string jstemplate { get; set; }
        public string asearchtemplate { get; set; }
        public short approval { get; set; }
        public short manageapproved { get; set; }
        public long scale { get; set; }
        public long assessed { get; set; }
        public long assesstimestart { get; set; }
        public long assesstimefinish { get; set; }
        public long defaultsort { get; set; }
        public short defaultsortdir { get; set; }
        public short editany { get; set; }
        public long notification { get; set; }
        public long timemodified { get; set; }
    }
}