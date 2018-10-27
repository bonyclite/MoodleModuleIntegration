using EducationalPlans.Domain;
using EducationalPlans.Parser.Api.Services;

namespace EducationalPlans.Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var parserService = new ParserService(@"C:\Users\vladi\Downloads\Telegram Desktop\38.03.02 МЛ-2017-ИТОГ\23.05.04_Д_2017-ИТОГ-1.plx");
            var fileRecords = parserService.GetFileRecords<Кафедры>();

            var d = 2;
        }
    }
}