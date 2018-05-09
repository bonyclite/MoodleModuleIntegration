namespace EducationalPlans.DomainModelsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pathForAdd = @"D:\VKR\src\EducationalPlans.Domain";
            const string xmlPath = @"C:\Users\vladi\Downloads\Telegram Desktop\38.03.02 МЛ-2017-ИТОГ\23.05.04_Д_2017-ИТОГ-1.plx";

            new DomainModelsGenerator(xmlPath, pathForAdd).Generate();
        }
    }
}