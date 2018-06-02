namespace StudentCard.Notifications.Extensions
{
    public class EmbeddedResources
    {
        public static string GetResource(string key)
        {
            return Common.Extensions.EmbeddedResources.GetResource(typeof(EmbeddedResources).Assembly, key);
        }
    }
}