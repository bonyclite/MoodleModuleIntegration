using EducationalPlans.Parser.Api.Models.Attributes;

namespace EducationalPlans.Parser.Api.Models
{
    [Route("GetStuStates")]
    public class StuState
    {
        public short Id { get; set; }
        public string StateName { get; set; }
        public string ActionName { get; set; }
        public string StateNick { get; set; }
    }
}