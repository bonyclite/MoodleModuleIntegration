namespace Moodle3KL.Domain
{
    public class mdl_external_functions : mdl_entity_base {
        public string name { get; set; }
        public string classname { get; set; }
        public string methodname { get; set; }
        public string classpath { get; set; }
        public string component { get; set; }
        public string capabilities { get; set; }
        public string services { get; set; }
    }
}