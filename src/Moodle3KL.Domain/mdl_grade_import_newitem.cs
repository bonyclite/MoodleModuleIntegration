namespace Moodle3KL.Domain
{
    public class mdl_grade_import_newitem : mdl_entity_base {
        public string itemname { get; set; }
        public long importcode { get; set; }
        public long importer { get; set; }
    }
}