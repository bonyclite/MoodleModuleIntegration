namespace Moodle3KL.Domain
{
    public class mdl_feedback_item : mdl_entity_base
    {
        public long feedback { get; set; }
        public long template { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public string presentation { get; set; }
        public string typ { get; set; }
        public short hasvalue { get; set; }
        public short position { get; set; }
        public short required { get; set; }
        public long dependitem { get; set; }
        public string dependvalue { get; set; }
        public string options { get; set; }
    }
}