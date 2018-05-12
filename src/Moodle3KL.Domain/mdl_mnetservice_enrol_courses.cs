namespace Moodle3KL.Domain
{
    public class mdl_mnetservice_enrol_courses
    {
        public long id { get; set; }
        public long hostid { get; set; }
        public long remoteid { get; set; }
        public long categoryid { get; set; }
        public string categoryname { get; set; }
        public long sortorder { get; set; }
        public string fullname { get; set; }
        public string shortname { get; set; }
        public string idnumber { get; set; }
        public string summary { get; set; }
        public short? summaryformat { get; set; }
        public long startdate { get; set; }
        public long roleid { get; set; }
        public string rolename { get; set; }
    }
}