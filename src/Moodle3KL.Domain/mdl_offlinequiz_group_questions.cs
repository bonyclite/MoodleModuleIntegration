namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_group_questions
    {
        public long id { get; set; }
        public long offlinequizid { get; set; }
        public long offlinegroupid { get; set; }
        public long questionid { get; set; }
        public short position { get; set; }
        public short? page { get; set; }
        public short? slot { get; set; }
        public decimal maxmark { get; set; }
    }
}