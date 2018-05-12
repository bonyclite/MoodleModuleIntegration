namespace Moodle3KL.Domain
{
    public class mdl_assignsubmission_file
    {
        public long id { get; set; }
        public long assignment { get; set; }
        public long submission { get; set; }
        public long numfiles { get; set; }
    }
}