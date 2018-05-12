namespace Moodle3KL.Domain
{
    public class mdl_mnetservice_enrol_enrolments
    {
        public long id { get; set; }
        public long hostid { get; set; }
        public long userid { get; set; }
        public long remotecourseid { get; set; }
        public string rolename { get; set; }
        public long enroltime { get; set; }
        public string enroltype { get; set; }
    }
}