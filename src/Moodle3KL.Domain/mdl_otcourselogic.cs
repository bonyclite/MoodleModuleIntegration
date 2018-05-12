namespace Moodle3KL.Domain
{
    public class mdl_otcourselogic : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string activecond { get; set; }
        public long? checkperiod { get; set; }
        public short catchstatechange { get; set; }
        public short catchcourseviewed { get; set; }
        public short studentshide { get; set; }
        public string redirectmessage { get; set; }
        public string redirecturl { get; set; }
        public string deliveryoptions { get; set; }
        public long? deliveryperiod { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short? completionstate { get; set; }
    }
}