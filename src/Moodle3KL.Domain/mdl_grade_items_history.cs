namespace Moodle3KL.Domain
{
    public class mdl_grade_items_history : mdl_entity_base
    {
        public long action { get; set; }
        public long oldid { get; set; }
        public string source { get; set; }
        public long? timemodified { get; set; }
        public long? loggeduser { get; set; }
        public long? courseid { get; set; }
        public long? categoryid { get; set; }
        public string itemname { get; set; }
        public string itemtype { get; set; }
        public string itemmodule { get; set; }
        public long? iteminstance { get; set; }
        public long? itemnumber { get; set; }
        public string iteminfo { get; set; }
        public string idnumber { get; set; }
        public string calculation { get; set; }
        public short gradetype { get; set; }
        public decimal grademax { get; set; }
        public decimal grademin { get; set; }
        public long? scaleid { get; set; }
        public long? outcomeid { get; set; }
        public decimal gradepass { get; set; }
        public decimal multfactor { get; set; }
        public decimal plusfactor { get; set; }
        public decimal aggregationcoef { get; set; }
        public decimal aggregationcoef2 { get; set; }
        public long sortorder { get; set; }
        public long hidden { get; set; }
        public long locked { get; set; }
        public long locktime { get; set; }
        public long needsupdate { get; set; }
        public long display { get; set; }
        public short? decimals { get; set; }
        public short weightoverride { get; set; }
    }
}