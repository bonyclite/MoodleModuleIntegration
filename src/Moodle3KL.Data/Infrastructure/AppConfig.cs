using System.Configuration;

namespace Moodle3KL.Data.Infrastructure
{
    public class AppConfig
    {
        public static string MoodleDecanatConnectionString => ConfigurationManager.ConnectionStrings["moodledecanat"].ConnectionString;
    }
}