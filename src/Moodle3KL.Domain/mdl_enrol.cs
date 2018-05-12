namespace Moodle3KL.Domain
{
    public class mdl_enrol : mdl_entity_base
    {
        public string enrol { get; set; }
        public long status { get; set; }
        public long courseid { get; set; }
        public long sortorder { get; set; }
        public string name { get; set; }
        public long? enrolperiod { get; set; }
        public long? enrolstartdate { get; set; }
        public long? enrolenddate { get; set; }
        public short? expirynotify { get; set; }
        public long? expirythreshold { get; set; }
        public short? notifyall { get; set; }
        public string password { get; set; }
        public string cost { get; set; }
        public string currency { get; set; }
        public long? roleid { get; set; }
        public long? customint1 { get; set; }
        public long? customint2 { get; set; }
        public long? customint3 { get; set; }
        public long? customint4 { get; set; }
        public long? customint5 { get; set; }
        public long? customint6 { get; set; }
        public long? customint7 { get; set; }
        public long? customint8 { get; set; }
        public string customchar1 { get; set; }
        public string customchar2 { get; set; }
        public string customchar3 { get; set; }
        public decimal? customdec1 { get; set; }
        public decimal? customdec2 { get; set; }
        public string customtext1 { get; set; }
        public string customtext2 { get; set; }
        public string customtext3 { get; set; }
        public string customtext4 { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}