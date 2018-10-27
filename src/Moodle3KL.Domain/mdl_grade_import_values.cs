namespace Moodle3KL.Domain
{
    public class mdl_grade_import_values : mdl_entity_base
    {
        public long? itemid { get; set; }
        public long? newgradeitem { get; set; }
        public long userid { get; set; }
        public decimal? finalgrade { get; set; }
        public string feedback { get; set; }
        public long importcode { get; set; }
        public long? importer { get; set; }
        public short? importonlyfeedback { get; set; }
    }
}