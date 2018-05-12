namespace Moodle3KL.Domain
{
    public class mdl_lti
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short? introformat { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long? typeid { get; set; }
        public string toolurl { get; set; }
        public string securetoolurl { get; set; }
        public short? instructorchoicesendname { get; set; }
        public short? instructorchoicesendemailaddr { get; set; }
        public short? instructorchoiceallowroster { get; set; }
        public short? instructorchoiceallowsetting { get; set; }
        public string instructorcustomparameters { get; set; }
        public short? instructorchoiceacceptgrades { get; set; }
        public long grade { get; set; }
        public short launchcontainer { get; set; }
        public string resourcekey { get; set; }
        public string password { get; set; }
        public short debuglaunch { get; set; }
        public short showtitlelaunch { get; set; }
        public short showdescriptionlaunch { get; set; }
        public string servicesalt { get; set; }
        public string icon { get; set; }
        public string secureicon { get; set; }
    }
}