namespace Moodle3KL.Domain
{
    public class mdl_folder : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long revision { get; set; }
        public long timemodified { get; set; }
        public short display { get; set; }
        public short showexpanded { get; set; }
        public short showdownloadfolder { get; set; }
    }
}