namespace Moodle3KL.Domain
{
    public class mdl_user_info_field
    {
        public long id { get; set; }
        public string shortname { get; set; }
        public string name { get; set; }
        public string datatype { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public long categoryid { get; set; }
        public long sortorder { get; set; }
        public short required { get; set; }
        public short locked { get; set; }
        public short visible { get; set; }
        public short forceunique { get; set; }
        public short signup { get; set; }
        public string defaultdata { get; set; }
        public short defaultdataformat { get; set; }
        public string param1 { get; set; }
        public string param2 { get; set; }
        public string param3 { get; set; }
        public string param4 { get; set; }
        public string param5 { get; set; }
    }
}