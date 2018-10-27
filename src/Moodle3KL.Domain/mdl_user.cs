namespace Moodle3KL.Domain
{
    public class mdl_user : mdl_entity_base
    {
        public string auth { get; set; }
        public short confirmed { get; set; }
        public short policyagreed { get; set; }
        public short deleted { get; set; }
        public short suspended { get; set; }
        public long mnethostid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string idnumber { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public short emailstop { get; set; }
        public string icq { get; set; }
        public string skype { get; set; }
        public string yahoo { get; set; }
        public string aim { get; set; }
        public string msn { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string institution { get; set; }
        public string department { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string lang { get; set; }
        public string calendartype { get; set; }
        public string theme { get; set; }
        public string timezone { get; set; }
        public long firstaccess { get; set; }
        public long lastaccess { get; set; }
        public long lastlogin { get; set; }
        public long currentlogin { get; set; }
        public string lastip { get; set; }
        public string secret { get; set; }
        public long picture { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public short mailformat { get; set; }
        public short maildigest { get; set; }
        public short maildisplay { get; set; }
        public short autosubscribe { get; set; }
        public short trackforums { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long trustbitmask { get; set; }
        public string imagealt { get; set; }
        public string lastnamephonetic { get; set; }
        public string firstnamephonetic { get; set; }
        public string middlename { get; set; }
        public string alternatename { get; set; }
    }
}